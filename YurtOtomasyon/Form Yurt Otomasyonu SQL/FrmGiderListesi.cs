using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Yurt_Otomasyonu_SQL
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet5.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet5.Giderler);

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmGider frm = new FrmGider();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            frm.giderid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.elektrk = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.Show();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
