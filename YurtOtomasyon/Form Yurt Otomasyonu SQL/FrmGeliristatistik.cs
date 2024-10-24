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
    public partial class FrmGeliristatistik : Form
    {
        public FrmGeliristatistik()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void FrmGeliristatistik_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("select sum(odememiktar) from kasa", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasa.Text = oku[0].ToString() + "TL";
            }
            conn.Close();
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select distinct(odemeay) from kasa", conn);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            conn.Close();
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select odemeay, sum(odememiktar) from kasa group by odemeay", conn);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            conn.Close();
        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("select sum(odememiktar) from kasa where odemeay=@p1", conn);
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkazanc.Text = oku[0].ToString();
            }
            conn.Close();
        }
    }
}
