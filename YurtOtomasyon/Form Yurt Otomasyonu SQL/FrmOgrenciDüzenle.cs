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
    public partial class FrmOgrenciDüzenle : Form
    {
        public FrmOgrenciDüzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,mail,odano,veliad,velitel,adres,bolum;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@id", conn);
            komutsil.Parameters.AddWithValue("@id", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlCommand komutoda = new SqlCommand("update odalar set odaaktif=odaaktif-1 where odano=@az1", conn);
            komutoda.Parameters.AddWithValue("@az1", CmbOdano.Text);
            komutoda.ExecuteNonQuery();
            conn.Close();

            FrmOgrenciListe frm = new FrmOgrenciListe();
            frm.Show();
            this.Hide();

        }

        SQLBaglantim bgl = new SQLBaglantim();
        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Ogrenci set Ograd=@p2, OgrSoyad=@p3,OgrTC=@p4,Ogrtelefon=@p5,ogrdogum=@p6,ogrmail=@p7,ogrodano=@p8,ogrveliadsoyad=@p9,ogrvelitelefon=@p10,ogrveliadres=@p11,ogrbolum=@p12 where ogrid=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrenciad.Text);
            komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", MskDogum.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", CmbOdano.Text);
            komut.Parameters.AddWithValue("@p9", TxtVeliAdSoy.Text);
            komut.Parameters.AddWithValue("@p10", MskVeliTel.Text);
            komut.Parameters.AddWithValue("@p11", RichAdres.Text);
            komut.Parameters.AddWithValue("@p12", CmbBolum.Text);
            komut.ExecuteNonQuery();
            conn.Close();

            FrmOgrenciListe frm = new FrmOgrenciListe();
            frm.Show();
            this.Hide();
        }

        private void FrmOgrenciDüzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrenciad.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select bolumad from bolumler", conn);
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku["bolumad"].ToString());
            }
            conn.Close();
            TxtMail.Text = mail;
            CmbOdano.Text = odano;
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select odano from odalar", conn);
            SqlDataReader oku2 = komut3.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdano.Items.Add(oku2["odano"].ToString());
            }
            conn.Close();
            TxtVeliAdSoy.Text = veliad;
            MskVeliTel.Text = velitel;
            RichAdres.Text = adres;


        }
    }
}
