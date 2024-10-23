using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_Yurt_Otomasyonu_SQL
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();

        private void FrmOgrenciKayit_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            
            SqlCommand komut2 = new SqlCommand("select OdaNo From Odalar where Odakapasite != OdaAKtif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        public void Listetemizle()
        {
            TxtOgrenciad.Clear();
            TxtOgrSoyad.Clear();
            MskTC.Clear();
            MskTelefon.Clear();
            MskDogum.Clear();
            TxtMail.Clear();
            CmbOdano.Text = "";
            TxtVeliAdSoy.Clear();
            MskVeliTel.Clear();
            RichAdres.Clear();
            CmbBolum.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum, OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", TxtOgrenciad.Text);
            komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
            komutkaydet.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
            komutkaydet.Parameters.AddWithValue("@p11", CmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@p6", TxtMail.Text);
            komutkaydet.Parameters.AddWithValue("@p7", CmbOdano.Text);
            komutkaydet.Parameters.AddWithValue("@p8", TxtVeliAdSoy.Text);
            komutkaydet.Parameters.AddWithValue("@p9", MskVeliTel.Text);
            komutkaydet.Parameters.AddWithValue("@p10", RichAdres.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            FrmOgrenciListe ogrlis = new FrmOgrenciListe();
            ogrlis.Show();
            this.Hide();

            SqlCommand komut3 = new SqlCommand("select ogrid from Ogrenci", bgl.baglanti());
            SqlDataReader oku = komut3.ExecuteReader();
            while (oku.Read())
            {
                label12.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", label12.Text);
            komut2.Parameters.AddWithValue("@b2", TxtOgrenciad.Text);
            komut2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            

            SqlCommand komutoda = new SqlCommand("update odalar set odaAktif=odaAktif+1 Where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

           // Listetemizle();
        }
    }
}
