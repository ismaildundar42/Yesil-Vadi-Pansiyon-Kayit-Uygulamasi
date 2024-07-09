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
    public partial class FrmHavaDurumu : Form
    {
        public FrmHavaDurumu()
        {
            InitializeComponent();
        }

        private void FrmHavaDurumu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Konya");
        }
    }
}
