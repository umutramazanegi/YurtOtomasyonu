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

namespace YurtOtomasyon
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        // GİRİŞ
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();      // Ana Formu göster.
                this.Hide();    // Admin giriş kısmını gizle.
            }
            else
            {
                MessageBox.Show("Hatalı Giriş! Kullanıcı adı veya şifre hatalı!");
                TxtKullaniciAd.Clear(); // Kullanıcı adı kısmını temizler.
                TxtSifre.Clear();       // Şifre kısmını temizler.
                TxtKullaniciAd.Focus(); // İmleci Kullanıcı adı kısmına getirir.
            }
            bgl.baglanti().Close();
        }
    }
}
