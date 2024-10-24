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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
           // SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2", bgl.baglanti());
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2", conn);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı yada şifre");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // LinkLabel'ın açacağı web sitesi adresini belirtin.
            string hedefURL = "https://umutramazanegi.com/";

            // System.Diagnostics.Process.Start() metodunu kullanarak varsayılan tarayıcıda URL'yi açın.
            System.Diagnostics.Process.Start(hedefURL);
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
