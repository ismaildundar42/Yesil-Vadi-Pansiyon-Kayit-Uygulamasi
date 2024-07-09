using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yesilVadiPansiyonDataSet3.tbl_faturalar' table. You can move, or remove it, as needed.
            this.tbl_faturalarTableAdapter.Fill(this.yesilVadiPansiyonDataSet3.tbl_faturalar);
            // TODO: This line of code loads data into the 'yesilVadiPansiyonDataSet2.tbl_AlinanUrunler' table. You can move, or remove it, as needed.
            this.tbl_AlinanUrunlerTableAdapter.Fill(this.yesilVadiPansiyonDataSet2.tbl_AlinanUrunler);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           

            
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_AlinanUrunler (Gida,Icecek,Cerezler) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtGidaTutari.Text);
            komut.Parameters.AddWithValue("@p2", txtIcecekTutari.Text);
            komut.Parameters.AddWithValue("@p3", txtGidaTutari.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            // DataGridView'i yenile
            this.tbl_AlinanUrunlerTableAdapter.Fill(this.yesilVadiPansiyonDataSet2.tbl_AlinanUrunler);
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_faturalar (Elektrik,Su,Internet) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
            komut.Parameters.AddWithValue("@p2", txtSu.Text);
            komut.Parameters.AddWithValue("@p3", txtInternet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.tbl_faturalarTableAdapter.Fill(this.yesilVadiPansiyonDataSet3.tbl_faturalar);
        }
    }
}
