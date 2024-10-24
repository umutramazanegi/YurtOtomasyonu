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
    public partial class FrmYoneticiislemleri : Form
    {
        public FrmYoneticiislemleri()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet6.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into admin(yoneticiad,yoneticisifre) values(@p1,@p2)", conn);
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtkullanicisifre.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            this.adminTableAdapter.Fill(this.yurtKayitDataSet6.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            Txtyoneticiid.Text = id;
            txtkullaniciad.Text = ad;
            txtkullanicisifre.Text = sifre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from admin where yoneticiid=@p1", conn);
            komut.Parameters.AddWithValue("@p1", Txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            this.adminTableAdapter.Fill(this.yurtKayitDataSet6.Admin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("update admin set yoneticiad=@p1,yoneticisifre=@p2 where yoneticiid=@p3", conn);
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtkullanicisifre.Text);
            komut.Parameters.AddWithValue("@p3", Txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            this.adminTableAdapter.Fill(this.yurtKayitDataSet6.Admin);

        }
    }
}
