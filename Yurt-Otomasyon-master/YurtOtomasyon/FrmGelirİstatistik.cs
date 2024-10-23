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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        // Form Yüklendiğinde.
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Sum (OdemeMiktar) From Kasa", bgl.baglanti());    //Kasa tablosundaki OdemeMiktar sütunundaki sayıları topla(sum).
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblPara.Text = oku[0].ToString() + " TL ";  //LblPara text'ine toplam parayı yaz.
            }
            bgl.baglanti().Close();

            // ComboBox'a ayları çekme.
            SqlCommand komut2 = new SqlCommand("Select distinct (OdemeAy) From Kasa", bgl.baglanti()); //distinct ---> Tekrar etmemesini sağlar.
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            // Grafiklere veri tabanından veri çekme.
            SqlCommand komut3 = new SqlCommand("Select OdemeAy, sum(odememiktar) from kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0],oku3[1]);
            }
            bgl.baglanti().Close();
        }

        // ComBox'ta seçilen ay değiştiğinde o ay kazanılan parayı göster.
        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Sum (OdemeMiktar) From Kasa Where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblAyKazanc.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
