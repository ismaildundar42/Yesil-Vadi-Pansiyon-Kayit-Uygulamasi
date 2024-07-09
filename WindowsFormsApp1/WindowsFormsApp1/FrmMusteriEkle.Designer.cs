namespace WindowsFormsApp1
{
    partial class FrmMusteriEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.txtTCkimlik = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn109 = new System.Windows.Forms.Button();
            this.btn108 = new System.Windows.Forms.Button();
            this.btn107 = new System.Windows.Forms.Button();
            this.btn106 = new System.Windows.Forms.Button();
            this.btn105 = new System.Windows.Forms.Button();
            this.btn104 = new System.Windows.Forms.Button();
            this.btn103 = new System.Windows.Forms.Button();
            this.btn102 = new System.Windows.Forms.Button();
            this.btn101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.txtOdaNumarasi);
            this.groupBox1.Controls.Add(this.txtTCkimlik);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 468);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(260, 30);
            this.dateTimePicker2.TabIndex = 23;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 423);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 30);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTelefon.Location = new System.Drawing.Point(169, 191);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(260, 34);
            this.txtTelefon.TabIndex = 21;
            this.txtTelefon.ValidatingType = typeof(int);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(169, 145);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(260, 36);
            this.cmbCinsiyet.TabIndex = 20;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(22, 516);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(407, 41);
            this.btnGirisYap.TabIndex = 19;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUcret.Location = new System.Drawing.Point(169, 370);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(260, 34);
            this.txtUcret.TabIndex = 16;
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.Enabled = false;
            this.txtOdaNumarasi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOdaNumarasi.Location = new System.Drawing.Point(169, 326);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(260, 34);
            this.txtOdaNumarasi.TabIndex = 11;
            // 
            // txtTCkimlik
            // 
            this.txtTCkimlik.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTCkimlik.Location = new System.Drawing.Point(169, 277);
            this.txtTCkimlik.MaxLength = 11;
            this.txtTCkimlik.Name = "txtTCkimlik";
            this.txtTCkimlik.Size = new System.Drawing.Size(260, 34);
            this.txtTCkimlik.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMail.Location = new System.Drawing.Point(169, 233);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(260, 34);
            this.txtMail.TabIndex = 14;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoyad.Location = new System.Drawing.Point(169, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(260, 34);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAd.Location = new System.Drawing.Point(169, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(260, 34);
            this.txtAd.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(46, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Çıkış Tarihi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(47, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giriş Tarihi : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(90, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ücret : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(17, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Oda Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(19, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "T.C. Numarası : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(99, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(75, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(74, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(87, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(112, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn109);
            this.groupBox2.Controls.Add(this.btn108);
            this.groupBox2.Controls.Add(this.btn107);
            this.groupBox2.Controls.Add(this.btn106);
            this.groupBox2.Controls.Add(this.btn105);
            this.groupBox2.Controls.Add(this.btn104);
            this.groupBox2.Controls.Add(this.btn103);
            this.groupBox2.Controls.Add(this.btn102);
            this.groupBox2.Controls.Add(this.btn101);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(481, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 579);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btn109
            // 
            this.btn109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn109.Location = new System.Drawing.Point(324, 362);
            this.btn109.Name = "btn109";
            this.btn109.Size = new System.Drawing.Size(95, 86);
            this.btn109.TabIndex = 8;
            this.btn109.Text = "109";
            this.btn109.UseVisualStyleBackColor = false;
            this.btn109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btn108
            // 
            this.btn108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn108.Location = new System.Drawing.Point(192, 362);
            this.btn108.Name = "btn108";
            this.btn108.Size = new System.Drawing.Size(95, 86);
            this.btn108.TabIndex = 7;
            this.btn108.Text = "108";
            this.btn108.UseVisualStyleBackColor = false;
            this.btn108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btn107
            // 
            this.btn107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn107.Location = new System.Drawing.Point(52, 362);
            this.btn107.Name = "btn107";
            this.btn107.Size = new System.Drawing.Size(95, 86);
            this.btn107.TabIndex = 6;
            this.btn107.Text = "107";
            this.btn107.UseVisualStyleBackColor = false;
            this.btn107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btn106
            // 
            this.btn106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn106.Location = new System.Drawing.Point(324, 231);
            this.btn106.Name = "btn106";
            this.btn106.Size = new System.Drawing.Size(95, 86);
            this.btn106.TabIndex = 5;
            this.btn106.Text = "106";
            this.btn106.UseVisualStyleBackColor = false;
            this.btn106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btn105
            // 
            this.btn105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn105.Location = new System.Drawing.Point(192, 231);
            this.btn105.Name = "btn105";
            this.btn105.Size = new System.Drawing.Size(95, 86);
            this.btn105.TabIndex = 4;
            this.btn105.Text = "105";
            this.btn105.UseVisualStyleBackColor = false;
            this.btn105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btn104
            // 
            this.btn104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn104.Location = new System.Drawing.Point(52, 231);
            this.btn104.Name = "btn104";
            this.btn104.Size = new System.Drawing.Size(95, 86);
            this.btn104.TabIndex = 3;
            this.btn104.Text = "104";
            this.btn104.UseVisualStyleBackColor = false;
            this.btn104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btn103
            // 
            this.btn103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn103.Location = new System.Drawing.Point(324, 90);
            this.btn103.Name = "btn103";
            this.btn103.Size = new System.Drawing.Size(95, 86);
            this.btn103.TabIndex = 2;
            this.btn103.Text = "103";
            this.btn103.UseVisualStyleBackColor = false;
            this.btn103.Click += new System.EventHandler(this.btnOda103_Click);
            // 
            // btn102
            // 
            this.btn102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn102.Location = new System.Drawing.Point(192, 90);
            this.btn102.Name = "btn102";
            this.btn102.Size = new System.Drawing.Size(95, 86);
            this.btn102.TabIndex = 1;
            this.btn102.Text = "102";
            this.btn102.UseVisualStyleBackColor = false;
            this.btn102.Click += new System.EventHandler(this.btnOda102_Click);
            // 
            // btn101
            // 
            this.btn101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn101.Location = new System.Drawing.Point(52, 90);
            this.btn101.Name = "btn101";
            this.btn101.Size = new System.Drawing.Size(95, 86);
            this.btn101.TabIndex = 0;
            this.btn101.Text = "101";
            this.btn101.UseVisualStyleBackColor = false;
            this.btn101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriEkle";
            this.Load += new System.EventHandler(this.FrmMusteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtOdaNumarasi;
        private System.Windows.Forms.TextBox txtTCkimlik;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn109;
        private System.Windows.Forms.Button btn108;
        private System.Windows.Forms.Button btn107;
        private System.Windows.Forms.Button btn106;
        private System.Windows.Forms.Button btn105;
        private System.Windows.Forms.Button btn104;
        private System.Windows.Forms.Button btn103;
        private System.Windows.Forms.Button btn102;
        private System.Windows.Forms.Button btn101;
    }
}