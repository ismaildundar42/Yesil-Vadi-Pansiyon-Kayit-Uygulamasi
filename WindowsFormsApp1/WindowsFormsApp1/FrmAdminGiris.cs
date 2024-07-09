using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True"))
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT COUNT(*) FROM tbl_adminler WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    int result = (int)komut.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        FrmAnaForm fr = new FrmAnaForm();
                        fr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.");
                        // Yeniden denemek için giriş alanlarını temizleme
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                        txtKullaniciAdi.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreGuncelleme fr = new FrmSifreGuncelleme();
            fr.Show();
        }
    }
}
