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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        public string giderid,elektrk, su, dogalgaz, internet, gıda, personel, diger;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Giderler set elektrik=@p1, su=@p2, dogalgaz=@p3,internet=@p4, gıda=@p5,personel=@p6,diger=@p7 where odemeid=@p8", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p8", txtgiderid.Text);
            komut2.Parameters.AddWithValue("@p1", Txtelektrk.Text);
            komut2.Parameters.AddWithValue("@p2", Txtsu.Text);
            komut2.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
            komut2.Parameters.AddWithValue("@p4", Txtinternet.Text);
            komut2.Parameters.AddWithValue("@p5", Txtgıda.Text);
            komut2.Parameters.AddWithValue("@p6", Txtpersonel.Text);
            komut2.Parameters.AddWithValue("@p7", TxtDiger.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            txtgiderid.Clear();
            Txtelektrk.Clear();
            Txtsu.Clear();
            TxtDogalgaz.Clear();
            Txtinternet.Clear();
            Txtgıda.Clear();
            Txtpersonel.Clear();
            TxtDiger.Clear();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Giderler(elektrik, su, dogalgaz,internet, gıda,personel,diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txtelektrk.Text);
            komut.Parameters.AddWithValue("@p2", Txtsu.Text);
            komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
            komut.Parameters.AddWithValue("@p5", Txtgıda.Text);
            komut.Parameters.AddWithValue("@p6", Txtpersonel.Text);
            komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
             
            Txtelektrk.Clear();
            Txtsu.Clear();
            TxtDogalgaz.Clear();
            Txtinternet.Clear();
            Txtgıda.Clear();
            Txtpersonel.Clear();
            TxtDiger.Clear();
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {
            txtgiderid.Text = giderid;
            Txtelektrk.Text = elektrk;
            Txtsu.Text = su;
            TxtDogalgaz.Text = dogalgaz;
            Txtinternet.Text = internet;
            Txtgıda.Text = gıda;
            Txtpersonel.Text = personel;
            TxtDiger.Text = diger;
        }
    }
}
