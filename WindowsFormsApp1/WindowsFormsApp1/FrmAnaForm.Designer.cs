namespace WindowsFormsApp1
{
    partial class FrmAnaForm
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnMusteriListesi = new System.Windows.Forms.Button();
            this.btnGelirGiderFormu = new System.Windows.Forms.Button();
            this.btnStoklar = new System.Windows.Forms.Button();
            this.btnMusteriMesajlari = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHavaDurumu = new System.Windows.Forms.Button();
            this.btnGazeteler = new System.Windows.Forms.Button();
            this.btnRaadyoDinle = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Location = new System.Drawing.Point(12, 105);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(145, 108);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYeniMusteri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.Location = new System.Drawing.Point(204, 105);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(145, 108);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOdalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdalar.Location = new System.Drawing.Point(398, 105);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(145, 108);
            this.btnOdalar.TabIndex = 2;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = false;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMusteriListesi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListesi.Location = new System.Drawing.Point(12, 239);
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.Size = new System.Drawing.Size(145, 108);
            this.btnMusteriListesi.TabIndex = 3;
            this.btnMusteriListesi.Text = "Müşteriler";
            this.btnMusteriListesi.UseVisualStyleBackColor = false;
            this.btnMusteriListesi.Click += new System.EventHandler(this.btnMusteriListesi_Click);
            // 
            // btnGelirGiderFormu
            // 
            this.btnGelirGiderFormu.BackColor = System.Drawing.Color.Violet;
            this.btnGelirGiderFormu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirGiderFormu.Location = new System.Drawing.Point(204, 239);
            this.btnGelirGiderFormu.Name = "btnGelirGiderFormu";
            this.btnGelirGiderFormu.Size = new System.Drawing.Size(145, 108);
            this.btnGelirGiderFormu.TabIndex = 4;
            this.btnGelirGiderFormu.Text = "Gelir-Gider Formu";
            this.btnGelirGiderFormu.UseVisualStyleBackColor = false;
            this.btnGelirGiderFormu.Click += new System.EventHandler(this.btnGelirGiderFormu_Click);
            // 
            // btnStoklar
            // 
            this.btnStoklar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStoklar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoklar.Location = new System.Drawing.Point(398, 239);
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.Size = new System.Drawing.Size(145, 108);
            this.btnStoklar.TabIndex = 5;
            this.btnStoklar.Text = "Giderler";
            this.btnStoklar.UseVisualStyleBackColor = false;
            this.btnStoklar.Click += new System.EventHandler(this.btnStoklar_Click);
            // 
            // btnMusteriMesajlari
            // 
            this.btnMusteriMesajlari.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMusteriMesajlari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriMesajlari.Location = new System.Drawing.Point(12, 386);
            this.btnMusteriMesajlari.Name = "btnMusteriMesajlari";
            this.btnMusteriMesajlari.Size = new System.Drawing.Size(145, 108);
            this.btnMusteriMesajlari.TabIndex = 6;
            this.btnMusteriMesajlari.Text = "Müşteri Mesajları";
            this.btnMusteriMesajlari.UseVisualStyleBackColor = false;
            this.btnMusteriMesajlari.Click += new System.EventHandler(this.btnMusteriMesajlari_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.BackColor = System.Drawing.Color.White;
            this.btnHakkimizda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkimizda.Location = new System.Drawing.Point(398, 386);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(145, 108);
            this.btnHakkimizda.TabIndex = 7;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.UseVisualStyleBackColor = false;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(315, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHavaDurumu
            // 
            this.btnHavaDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHavaDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavaDurumu.Location = new System.Drawing.Point(599, 105);
            this.btnHavaDurumu.Name = "btnHavaDurumu";
            this.btnHavaDurumu.Size = new System.Drawing.Size(145, 108);
            this.btnHavaDurumu.TabIndex = 10;
            this.btnHavaDurumu.Text = "Hava Durumu";
            this.btnHavaDurumu.UseVisualStyleBackColor = false;
            this.btnHavaDurumu.Click += new System.EventHandler(this.btnHavaDurumu_Click);
            // 
            // btnGazeteler
            // 
            this.btnGazeteler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGazeteler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGazeteler.Location = new System.Drawing.Point(599, 239);
            this.btnGazeteler.Name = "btnGazeteler";
            this.btnGazeteler.Size = new System.Drawing.Size(145, 108);
            this.btnGazeteler.TabIndex = 11;
            this.btnGazeteler.Text = "Gazeteler";
            this.btnGazeteler.UseVisualStyleBackColor = false;
            this.btnGazeteler.Click += new System.EventHandler(this.btnGazeteler_Click);
            // 
            // btnRaadyoDinle
            // 
            this.btnRaadyoDinle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRaadyoDinle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaadyoDinle.Location = new System.Drawing.Point(204, 386);
            this.btnRaadyoDinle.Name = "btnRaadyoDinle";
            this.btnRaadyoDinle.Size = new System.Drawing.Size(145, 108);
            this.btnRaadyoDinle.TabIndex = 12;
            this.btnRaadyoDinle.Text = "Radyo Dinle";
            this.btnRaadyoDinle.UseVisualStyleBackColor = false;
            this.btnRaadyoDinle.Click += new System.EventHandler(this.btnRaadyoDinle_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.Firebrick;
            this.btnÇıkış.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Location = new System.Drawing.Point(599, 386);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(145, 108);
            this.btnÇıkış.TabIndex = 13;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = false;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(773, 537);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnRaadyoDinle);
            this.Controls.Add(this.btnGazeteler);
            this.Controls.Add(this.btnHavaDurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnMusteriMesajlari);
            this.Controls.Add(this.btnStoklar);
            this.Controls.Add(this.btnGelirGiderFormu);
            this.Controls.Add(this.btnMusteriListesi);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.btnAdminGiris);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gazeteler";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnMusteriListesi;
        private System.Windows.Forms.Button btnGelirGiderFormu;
        private System.Windows.Forms.Button btnStoklar;
        private System.Windows.Forms.Button btnMusteriMesajlari;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHavaDurumu;
        private System.Windows.Forms.Button btnGazeteler;
        private System.Windows.Forms.Button btnRaadyoDinle;
        private System.Windows.Forms.Button btnÇıkış;
    }
}

