namespace Form_Yurt_Otomasyonu_SQL
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbBolumekle = new System.Windows.Forms.PictureBox();
            this.PcbBolumsil = new System.Windows.Forms.PictureBox();
            this.PcbBolumguncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.TxtBolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSet();
            this.bolumlerTableAdapter = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumguncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbBolumekle
            // 
            this.PcbBolumekle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumekle.Image")));
            this.PcbBolumekle.Location = new System.Drawing.Point(96, 15);
            this.PcbBolumekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PcbBolumekle.Name = "PcbBolumekle";
            this.PcbBolumekle.Size = new System.Drawing.Size(87, 43);
            this.PcbBolumekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumekle.TabIndex = 0;
            this.PcbBolumekle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumekle, "Bölüm Ekle");
            this.PcbBolumekle.Click += new System.EventHandler(this.PcbBolumekle_Click);
            // 
            // PcbBolumsil
            // 
            this.PcbBolumsil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumsil.Image")));
            this.PcbBolumsil.Location = new System.Drawing.Point(237, 15);
            this.PcbBolumsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PcbBolumsil.Name = "PcbBolumsil";
            this.PcbBolumsil.Size = new System.Drawing.Size(87, 43);
            this.PcbBolumsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumsil.TabIndex = 1;
            this.PcbBolumsil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumsil, "Bölüm Sil");
            this.PcbBolumsil.Click += new System.EventHandler(this.PcbBolumsil_Click);
            // 
            // PcbBolumguncelle
            // 
            this.PcbBolumguncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumguncelle.Image")));
            this.PcbBolumguncelle.Location = new System.Drawing.Point(383, 15);
            this.PcbBolumguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PcbBolumguncelle.Name = "PcbBolumguncelle";
            this.PcbBolumguncelle.Size = new System.Drawing.Size(87, 43);
            this.PcbBolumguncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumguncelle.TabIndex = 2;
            this.PcbBolumguncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumguncelle, "Bölüm Güncelleme");
            this.PcbBolumguncelle.Click += new System.EventHandler(this.PcbBolumguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bolum ID:";
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumid.Location = new System.Drawing.Point(173, 86);
            this.TxtBolumid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(313, 35);
            this.TxtBolumid.TabIndex = 4;
            // 
            // TxtBolumad
            // 
            this.TxtBolumad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumad.Location = new System.Drawing.Point(173, 135);
            this.TxtBolumad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBolumad.Name = "TxtBolumad";
            this.TxtBolumad.Size = new System.Drawing.Size(313, 35);
            this.TxtBolumad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bolum Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 245);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayitDataSet;
            // 
            // yurtKayitDataSet
            // 
            this.yurtKayitDataSet.DataSetName = "YurtKayitDataSet";
            this.yurtKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBolumguncelle);
            this.Controls.Add(this.PcbBolumsil);
            this.Controls.Add(this.PcbBolumekle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumguncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumekle;
        private System.Windows.Forms.PictureBox PcbBolumsil;
        private System.Windows.Forms.PictureBox PcbBolumguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.TextBox TxtBolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet yurtKayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}