using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class FrmGelirGiderFormu : Form
    {
        public FrmGelirGiderFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmGelirGiderFormu_Load(object sender, EventArgs e)
        {
            // kasadaki paraların toplamı 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(Ucret) as toplam from tbl_musteriler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKasaToplam.Text = dr["toplam"].ToString() ;
            }
            baglanti.Close();

            // gida giderlerin toplamı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(Gida) as toplam2 from tbl_AlinanUrunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblGida.Text = dr2["toplam2"].ToString();
            }
            baglanti.Close();

            // içecek giderlerin toplamı 
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT SUM(Icecek) as toplam3 from tbl_AlinanUrunler", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblIcecek.Text = dr3["toplam3"].ToString();
            }
            baglanti.Close();

            // çerez giderler toplamı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT SUM(Icecek) as toplam4 from tbl_AlinanUrunler", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblCerez.Text = dr4["toplam4"].ToString();
            }
            baglanti.Close();

            // elektrik giderler toplamı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT SUM(Elektrik) as toplam5 from tbl_faturalar", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblElektrik.Text = dr5["toplam5"].ToString();
            }
            baglanti.Close();

            // su giderler toplamı
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT SUM(Su) as toplam6 from tbl_faturalar", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblSu.Text = dr6["toplam6"].ToString();
            }
            baglanti.Close();

            // internet giderler toplamı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("SELECT SUM(Internet) as toplam7 from tbl_faturalar", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblInternet.Text = dr7["toplam7"].ToString();
            }
            baglanti.Close();

            lblAlinanUrunToplami.Text = (int.Parse(lblGida.Text)+int.Parse(lblCerez.Text)+int.Parse(lblIcecek.Text)).ToString();

            lblFaturalar.Text = (int.Parse(lblElektrik.Text) + int.Parse(lblSu.Text) + int.Parse(lblInternet.Text)).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            //personel giderler toplamı 
            int personelSayisi = int.Parse(txtPersonelSayisi.Text);
            lblPersonelMaaslari.Text = (personelSayisi * 17002).ToString();


            int gelir = int.Parse(lblKasaToplam.Text);
            int gider = int.Parse(lblPersonelMaaslari.Text) + int.Parse(lblFaturalar.Text) + int.Parse(lblAlinanUrunToplami.Text);
            int sonuc = gelir - gider;
            lblSonuc.Text = sonuc.ToString()+" ₺";
            if(sonuc<0)
            {
                lblDurum.Text = "ZARAR " +Math.Abs(sonuc).ToString()+" ₺";
                lblDurum.ForeColor = Color.Red;
            }
            else
            {
                lblDurum.Text = "KAR " + Math.Abs(sonuc).ToString() + " ₺";
                lblDurum.ForeColor = Color.Green;
            }
        }
    }
}
