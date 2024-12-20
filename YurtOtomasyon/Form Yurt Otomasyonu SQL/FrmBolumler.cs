﻿using System;
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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
        }
        public void temizle()
        {
            TxtBolumid.Clear();
            TxtBolumad.Clear();
        }

        SQLBaglantim bgl = new SQLBaglantim();
        
        private void PcbBolumekle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into bolumler(bolumad) values(@p1)", conn);
            komut.Parameters.AddWithValue("@p1", TxtBolumad.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bölüm Eklendi");
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            temizle();
        }

        private void PcbBolumsil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from bolumler where bolumid=@id", conn);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silme İşlem Tamam");
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBolumid.Text = id;
            TxtBolumad.Text = ad;
        }

        private void PcbBolumguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.baglanti);
            conn.Open();
            SqlCommand komut2 = new SqlCommand("update Bolumler Set Bolumad=@ad where bolumid=@id", conn);
            komut2.Parameters.AddWithValue("@id", TxtBolumid.Text);
            komut2.Parameters.AddWithValue("@ad", TxtBolumad.Text);
            komut2.ExecuteNonQuery();
            conn.Close();
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            temizle();
        }
    }
}
