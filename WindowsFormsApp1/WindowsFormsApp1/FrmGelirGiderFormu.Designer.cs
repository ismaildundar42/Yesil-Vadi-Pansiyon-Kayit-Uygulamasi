namespace WindowsFormsApp1
{
    partial class FrmGelirGiderFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKasaToplam = new System.Windows.Forms.Label();
            this.lblPersonelMaaslari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAlinanUrunToplami = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFaturalar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelSayisi = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblGida = new System.Windows.Forms.Label();
            this.lblIcecek = new System.Windows.Forms.Label();
            this.lblCerez = new System.Windows.Forms.Label();
            this.lblElektrik = new System.Windows.Forms.Label();
            this.lblSu = new System.Windows.Forms.Label();
            this.lblInternet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Toplam Tutar : ";
            // 
            // lblKasaToplam
            // 
            this.lblKasaToplam.AutoSize = true;
            this.lblKasaToplam.Location = new System.Drawing.Point(295, 48);
            this.lblKasaToplam.Name = "lblKasaToplam";
            this.lblKasaToplam.Size = new System.Drawing.Size(40, 31);
            this.lblKasaToplam.TabIndex = 1;
            this.lblKasaToplam.Text = "00";
            // 
            // lblPersonelMaaslari
            // 
            this.lblPersonelMaaslari.AutoSize = true;
            this.lblPersonelMaaslari.Location = new System.Drawing.Point(295, 103);
            this.lblPersonelMaaslari.Name = "lblPersonelMaaslari";
            this.lblPersonelMaaslari.Size = new System.Drawing.Size(40, 31);
            this.lblPersonelMaaslari.TabIndex = 3;
            this.lblPersonelMaaslari.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Personel Maaşları : ";
            // 
            // lblAlinanUrunToplami
            // 
            this.lblAlinanUrunToplami.AutoSize = true;
            this.lblAlinanUrunToplami.Location = new System.Drawing.Point(295, 160);
            this.lblAlinanUrunToplami.Name = "lblAlinanUrunToplami";
            this.lblAlinanUrunToplami.Size = new System.Drawing.Size(40, 31);
            this.lblAlinanUrunToplami.TabIndex = 5;
            this.lblAlinanUrunToplami.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Alınan Ürün Tutarları : ";
            // 
            // lblFaturalar
            // 
            this.lblFaturalar.AutoSize = true;
            this.lblFaturalar.Location = new System.Drawing.Point(293, 216);
            this.lblFaturalar.Name = "lblFaturalar";
            this.lblFaturalar.Size = new System.Drawing.Size(40, 31);
            this.lblFaturalar.TabIndex = 7;
            this.lblFaturalar.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Faturalar : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Personel Sayısı : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(219, 301);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(401, 39);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(770, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "---";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPersonelSayisi
            // 
            this.txtPersonelSayisi.Location = new System.Drawing.Point(636, 52);
            this.txtPersonelSayisi.Name = "txtPersonelSayisi";
            this.txtPersonelSayisi.Size = new System.Drawing.Size(41, 38);
            this.txtPersonelSayisi.TabIndex = 12;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(465, 375);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(40, 31);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 31);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sonuç : ";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(465, 437);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(70, 31);
            this.lblDurum.TabIndex = 16;
            this.lblDurum.Text = "NULL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 31);
            this.label14.TabIndex = 15;
            this.label14.Text = "Durum : ";
            // 
            // lblGida
            // 
            this.lblGida.AutoSize = true;
            this.lblGida.Location = new System.Drawing.Point(390, 160);
            this.lblGida.Name = "lblGida";
            this.lblGida.Size = new System.Drawing.Size(40, 31);
            this.lblGida.TabIndex = 17;
            this.lblGida.Text = "00";
            this.lblGida.Visible = false;
            // 
            // lblIcecek
            // 
            this.lblIcecek.AutoSize = true;
            this.lblIcecek.Location = new System.Drawing.Point(479, 160);
            this.lblIcecek.Name = "lblIcecek";
            this.lblIcecek.Size = new System.Drawing.Size(40, 31);
            this.lblIcecek.TabIndex = 18;
            this.lblIcecek.Text = "00";
            this.lblIcecek.Visible = false;
            // 
            // lblCerez
            // 
            this.lblCerez.AutoSize = true;
            this.lblCerez.Location = new System.Drawing.Point(565, 160);
            this.lblCerez.Name = "lblCerez";
            this.lblCerez.Size = new System.Drawing.Size(40, 31);
            this.lblCerez.TabIndex = 19;
            this.lblCerez.Text = "00";
            this.lblCerez.Visible = false;
            // 
            // lblElektrik
            // 
            this.lblElektrik.AutoSize = true;
            this.lblElektrik.Location = new System.Drawing.Point(390, 226);
            this.lblElektrik.Name = "lblElektrik";
            this.lblElektrik.Size = new System.Drawing.Size(40, 31);
            this.lblElektrik.TabIndex = 20;
            this.lblElektrik.Text = "00";
            this.lblElektrik.Visible = false;
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Location = new System.Drawing.Point(479, 226);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(40, 31);
            this.lblSu.TabIndex = 21;
            this.lblSu.Text = "00";
            this.lblSu.Visible = false;
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Location = new System.Drawing.Point(565, 226);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(40, 31);
            this.lblInternet.TabIndex = 22;
            this.lblInternet.Text = "00";
            this.lblInternet.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "₺";
            // 
            // FrmGelirGiderFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(896, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInternet);
            this.Controls.Add(this.lblSu);
            this.Controls.Add(this.lblElektrik);
            this.Controls.Add(this.lblCerez);
            this.Controls.Add(this.lblIcecek);
            this.Controls.Add(this.lblGida);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPersonelSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFaturalar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAlinanUrunToplami);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPersonelMaaslari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKasaToplam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirGiderFormu";
            this.Text = "Gelir Gider Formu";
            this.Load += new System.EventHandler(this.FrmGelirGiderFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKasaToplam;
        private System.Windows.Forms.Label lblPersonelMaaslari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAlinanUrunToplami;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFaturalar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelSayisi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblGida;
        private System.Windows.Forms.Label lblIcecek;
        private System.Windows.Forms.Label lblCerez;
        private System.Windows.Forms.Label lblElektrik;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}