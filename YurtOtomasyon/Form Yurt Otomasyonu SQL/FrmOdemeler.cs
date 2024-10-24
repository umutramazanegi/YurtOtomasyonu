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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
           
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet3.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrid.Text = id;
            textBad.Text = ad;
            TxtSoyad.Text = soyad;
            TxtKalan.Text= kalan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt32(TxtOdenen.Text);
            kalan = Convert.ToInt32(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("update borclar set ogrkalanborc=@p1 where ogrid=@p2",conn);
            komut.Parameters.AddWithValue("@p2", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            conn.Close();

            this.borclarTableAdapter.Fill(this.yurtKayitDataSet3.Borclar);
            conn.Open();
            SqlCommand komut2 = new SqlCommand("insert into Kasa(odemeay,odememiktar) values (@k1,@k2)", conn);
            komut2.Parameters.AddWithValue("@k1", CmbxOdenenay.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
