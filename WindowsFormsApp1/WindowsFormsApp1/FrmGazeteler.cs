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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         //   webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://www.hurriyet.com.tr/");
            }
            catch (Exception)
            {

                MessageBox.Show("beklenmedik bir hata !");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.turkiyegazetesi.com.tr/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fotomac.com.tr/");

        }
    }
}
