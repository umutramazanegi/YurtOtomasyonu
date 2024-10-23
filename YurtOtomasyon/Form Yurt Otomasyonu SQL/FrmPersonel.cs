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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet7.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet7.Personel);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel(personeladsoyad, personeldepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", cmbxgorev.Text);
            komut.ExecuteNonQuery();
            this.personelTableAdapter.Fill(this.yurtKayitDataSet7.Personel);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update personel set personeladsoyad=@p1,personeldepartman=@p2 where personelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", cmbxgorev.Text);
            komut.Parameters.AddWithValue("@p3", Txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.personelTableAdapter.Fill(this.yurtKayitDataSet7.Personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string adsoy = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            Txtpersonelid.Text = id;
            txtpersonelad.Text = adsoy;
            cmbxgorev.Text = gorev;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from personel where personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.personelTableAdapter.Fill(this.yurtKayitDataSet7.Personel);
        }
    }
}
