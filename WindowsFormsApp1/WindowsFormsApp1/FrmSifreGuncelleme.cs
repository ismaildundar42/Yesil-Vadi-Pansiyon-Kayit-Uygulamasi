using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class FrmSifreGuncelleme : Form
    {
        public FrmSifreGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_adminler set sifre=@p1 where kullaniciAdi=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", txtKullaniciAdi.Text);

                int affectedRows = komut.ExecuteNonQuery();
                baglanti.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Şifreniz başarılı bir şekilde güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı bulunamadı, şifre güncellenemedi.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }

    }
}
