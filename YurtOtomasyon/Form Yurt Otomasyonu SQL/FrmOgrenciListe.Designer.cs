namespace Form_Yurt_Otomasyonu_SQL
{
    partial class FrmOgrenciListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet4 = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSet4();
            this.ogrenciTableAdapter = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSet4TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrDogumDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn,
            this.ogrVeliAdresDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            // 
            // ogrDogumDataGridViewTextBoxColumn
            // 
            this.ogrDogumDataGridViewTextBoxColumn.DataPropertyName = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.HeaderText = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.Name = "ogrDogumDataGridViewTextBoxColumn";
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.Name = "ogrVeliAdresDataGridViewTextBoxColumn";
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtKayitDataSet4;
            // 
            // yurtKayitDataSet4
            // 
            this.yurtKayitDataSet4.DataSetName = "YurtKayitDataSet4";
            this.yurtKayitDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 475);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgrenciListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Liste";
            this.Load += new System.EventHandler(this.FrmOgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet4 yurtKayitDataSet4;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtKayitDataSet4TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
    }
}