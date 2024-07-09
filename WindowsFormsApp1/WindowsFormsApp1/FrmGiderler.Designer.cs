namespace WindowsFormsApp1
{
    partial class FrmGiderler
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
            this.yesilVadiPansiyonDataSet2 = new WindowsFormsApp1.YesilVadiPansiyonDataSet2();
            this.tblAlinanUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AlinanUrunlerTableAdapter = new WindowsFormsApp1.YesilVadiPansiyonDataSet2TableAdapters.tbl_AlinanUrunlerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıcecekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerezlerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtCerezTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIcecekTutari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGidaTutari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfaturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yesilVadiPansiyonDataSet3 = new WindowsFormsApp1.YesilVadiPansiyonDataSet3();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbl_faturalarTableAdapter = new WindowsFormsApp1.YesilVadiPansiyonDataSet3TableAdapters.tbl_faturalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlinanUrunlerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // yesilVadiPansiyonDataSet2
            // 
            this.yesilVadiPansiyonDataSet2.DataSetName = "YesilVadiPansiyonDataSet2";
            this.yesilVadiPansiyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAlinanUrunlerBindingSource
            // 
            this.tblAlinanUrunlerBindingSource.DataMember = "tbl_AlinanUrunler";
            this.tblAlinanUrunlerBindingSource.DataSource = this.yesilVadiPansiyonDataSet2;
            // 
            // tbl_AlinanUrunlerTableAdapter
            // 
            this.tbl_AlinanUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtCerezTutari);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIcecekTutari);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGidaTutari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Giderleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidaDataGridViewTextBoxColumn,
            this.ıcecekDataGridViewTextBoxColumn,
            this.cerezlerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAlinanUrunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 279);
            this.dataGridView1.TabIndex = 15;
            // 
            // gidaDataGridViewTextBoxColumn
            // 
            this.gidaDataGridViewTextBoxColumn.DataPropertyName = "Gida";
            this.gidaDataGridViewTextBoxColumn.HeaderText = "Gida";
            this.gidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gidaDataGridViewTextBoxColumn.Name = "gidaDataGridViewTextBoxColumn";
            this.gidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıcecekDataGridViewTextBoxColumn
            // 
            this.ıcecekDataGridViewTextBoxColumn.DataPropertyName = "Icecek";
            this.ıcecekDataGridViewTextBoxColumn.HeaderText = "Icecek";
            this.ıcecekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıcecekDataGridViewTextBoxColumn.Name = "ıcecekDataGridViewTextBoxColumn";
            this.ıcecekDataGridViewTextBoxColumn.Width = 125;
            // 
            // cerezlerDataGridViewTextBoxColumn
            // 
            this.cerezlerDataGridViewTextBoxColumn.DataPropertyName = "Cerezler";
            this.cerezlerDataGridViewTextBoxColumn.HeaderText = "Cerezler";
            this.cerezlerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cerezlerDataGridViewTextBoxColumn.Name = "cerezlerDataGridViewTextBoxColumn";
            this.cerezlerDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(126, 194);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(205, 33);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // txtCerezTutari
            // 
            this.txtCerezTutari.Location = new System.Drawing.Point(218, 143);
            this.txtCerezTutari.Name = "txtCerezTutari";
            this.txtCerezTutari.Size = new System.Drawing.Size(150, 30);
            this.txtCerezTutari.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Çerez Tutarları : ";
            // 
            // txtIcecekTutari
            // 
            this.txtIcecekTutari.Location = new System.Drawing.Point(218, 97);
            this.txtIcecekTutari.Name = "txtIcecekTutari";
            this.txtIcecekTutari.Size = new System.Drawing.Size(150, 30);
            this.txtIcecekTutari.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "İçecek Tutarları : ";
            // 
            // txtGidaTutari
            // 
            this.txtGidaTutari.Location = new System.Drawing.Point(218, 51);
            this.txtGidaTutari.Name = "txtGidaTutari";
            this.txtGidaTutari.Size = new System.Drawing.Size(150, 30);
            this.txtGidaTutari.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gıda Tutarları : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnKaydet2);
            this.groupBox2.Controls.Add(this.txtInternet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(516, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 566);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Giderleri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.ınternetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblfaturalarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(429, 279);
            this.dataGridView2.TabIndex = 22;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınternetDataGridViewTextBoxColumn
            // 
            this.ınternetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.ınternetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.ınternetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınternetDataGridViewTextBoxColumn.Name = "ınternetDataGridViewTextBoxColumn";
            this.ınternetDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblfaturalarBindingSource
            // 
            this.tblfaturalarBindingSource.DataMember = "tbl_faturalar";
            this.tblfaturalarBindingSource.DataSource = this.yesilVadiPansiyonDataSet3;
            // 
            // yesilVadiPansiyonDataSet3
            // 
            this.yesilVadiPansiyonDataSet3.DataSetName = "YesilVadiPansiyonDataSet3";
            this.yesilVadiPansiyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Location = new System.Drawing.Point(153, 193);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(205, 33);
            this.btnKaydet2.TabIndex = 21;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(198, 142);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(150, 30);
            this.txtInternet.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "İnternet : ";
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(198, 96);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(150, 30);
            this.txtSu.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Su : ";
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(198, 50);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(150, 30);
            this.txtElektrik.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elektrik : ";
            // 
            // tbl_faturalarTableAdapter
            // 
            this.tbl_faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler Formu";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlinanUrunlerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YesilVadiPansiyonDataSet2 yesilVadiPansiyonDataSet2;
        private System.Windows.Forms.BindingSource tblAlinanUrunlerBindingSource;
        private YesilVadiPansiyonDataSet2TableAdapters.tbl_AlinanUrunlerTableAdapter tbl_AlinanUrunlerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcecekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cerezlerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtCerezTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIcecekTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGidaTutari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label6;
        private YesilVadiPansiyonDataSet3 yesilVadiPansiyonDataSet3;
        private System.Windows.Forms.BindingSource tblfaturalarBindingSource;
        private YesilVadiPansiyonDataSet3TableAdapters.tbl_faturalarTableAdapter tbl_faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetDataGridViewTextBoxColumn;
    }
}