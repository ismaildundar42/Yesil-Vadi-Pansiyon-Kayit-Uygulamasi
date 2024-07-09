using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yesil Vadi Pansiyonu Konyada 2024 yılında kurulmuş bir işletmedir.");
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGelirGiderFormu_Click(object sender, EventArgs e)
        {
            FrmGelirGiderFormu fr = new FrmGelirGiderFormu();
            fr.Show();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.Show();
        }

        private void btnRaadyoDinle_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void btnGazeteler_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void btnHavaDurumu_Click(object sender, EventArgs e)
        {
            FrmHavaDurumu fr = new FrmHavaDurumu();
            fr.Show();
        }
    }
}
