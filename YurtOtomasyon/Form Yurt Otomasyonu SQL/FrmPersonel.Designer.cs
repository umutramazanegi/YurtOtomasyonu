namespace Form_Yurt_Otomasyonu_SQL
{
    partial class FrmPersonel
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
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet7 = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSet7();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpersonelad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtpersonelid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelTableAdapter = new Form_Yurt_Otomasyonu_SQL.YurtKayitDataSet7TableAdapters.PersonelTableAdapter();
            this.cmbxgorev = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(147, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 185);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtKayitDataSet7;
            // 
            // yurtKayitDataSet7
            // 
            this.yurtKayitDataSet7.DataSetName = "YurtKayitDataSet7";
            this.yurtKayitDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(479, 188);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(125, 44);
            this.btnsil.TabIndex = 20;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(328, 188);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(125, 44);
            this.btnguncelle.TabIndex = 19;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(177, 188);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 44);
            this.BtnKaydet.TabIndex = 18;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Personel Görev :";
            // 
            // txtpersonelad
            // 
            this.txtpersonelad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpersonelad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelad.Location = new System.Drawing.Point(265, 70);
            this.txtpersonelad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpersonelad.Name = "txtpersonelad";
            this.txtpersonelad.Size = new System.Drawing.Size(337, 30);
            this.txtpersonelad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Personel  Ad Soyad :";
            // 
            // Txtpersonelid
            // 
            this.Txtpersonelid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txtpersonelid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtpersonelid.Location = new System.Drawing.Point(265, 17);
            this.Txtpersonelid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtpersonelid.Name = "Txtpersonelid";
            this.Txtpersonelid.Size = new System.Drawing.Size(337, 30);
            this.Txtpersonelid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personel ID :";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // cmbxgorev
            // 
            this.cmbxgorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbxgorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxgorev.FormattingEnabled = true;
            this.cmbxgorev.Items.AddRange(new object[] {
            "Genel Müdür",
            "Müdür",
            "Yönetici",
            "Aşçı",
            "Temizlik Görevlisi",
            "Güvenlik"});
            this.cmbxgorev.Location = new System.Drawing.Point(265, 121);
            this.cmbxgorev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxgorev.Name = "cmbxgorev";
            this.cmbxgorev.Size = new System.Drawing.Size(337, 28);
            this.cmbxgorev.TabIndex = 22;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(708, 466);
            this.Controls.Add(this.cmbxgorev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpersonelad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtpersonelid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpersonelad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtpersonelid;
        private System.Windows.Forms.Label label1;
        private YurtKayitDataSet7 yurtKayitDataSet7;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtKayitDataSet7TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbxgorev;
    }
}