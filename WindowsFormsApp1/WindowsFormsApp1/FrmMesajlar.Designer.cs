namespace WindowsFormsApp1
{
    partial class FrmMesajlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yesilVadiPansiyonDataSet4 = new WindowsFormsApp1.YesilVadiPansiyonDataSet4();
            this.tblmesajlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mesajlarTableAdapter = new WindowsFormsApp1.YesilVadiPansiyonDataSet4TableAdapters.tbl_mesajlarTableAdapter();
            this.mesajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesajlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "İçerik : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 133);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesajidDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.icerikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmesajlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 191);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // yesilVadiPansiyonDataSet4
            // 
            this.yesilVadiPansiyonDataSet4.DataSetName = "YesilVadiPansiyonDataSet4";
            this.yesilVadiPansiyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmesajlarBindingSource
            // 
            this.tblmesajlarBindingSource.DataMember = "tbl_mesajlar";
            this.tblmesajlarBindingSource.DataSource = this.yesilVadiPansiyonDataSet4;
            // 
            // tbl_mesajlarTableAdapter
            // 
            this.tbl_mesajlarTableAdapter.ClearBeforeFill = true;
            // 
            // mesajidDataGridViewTextBoxColumn
            // 
            this.mesajidDataGridViewTextBoxColumn.DataPropertyName = "mesajid";
            this.mesajidDataGridViewTextBoxColumn.HeaderText = "mesajid";
            this.mesajidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajidDataGridViewTextBoxColumn.Name = "mesajidDataGridViewTextBoxColumn";
            this.mesajidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesajidDataGridViewTextBoxColumn.Width = 125;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // icerikDataGridViewTextBoxColumn
            // 
            this.icerikDataGridViewTextBoxColumn.DataPropertyName = "icerik";
            this.icerikDataGridViewTextBoxColumn.HeaderText = "icerik";
            this.icerikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.icerikDataGridViewTextBoxColumn.Name = "icerikDataGridViewTextBoxColumn";
            this.icerikDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(492, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMesajlar";
            this.Text = "Mesajlar Formu";
            this.Load += new System.EventHandler(this.FrmMesajlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesilVadiPansiyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesajlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YesilVadiPansiyonDataSet4 yesilVadiPansiyonDataSet4;
        private System.Windows.Forms.BindingSource tblmesajlarBindingSource;
        private YesilVadiPansiyonDataSet4TableAdapters.tbl_mesajlarTableAdapter tbl_mesajlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icerikDataGridViewTextBoxColumn;
    }
}