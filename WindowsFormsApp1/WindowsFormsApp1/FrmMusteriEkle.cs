using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret = 0;

            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc = cikisTarihi - girisTarihi;

            Ucret = 700 * Convert.ToInt32(sonuc.TotalDays);
            if(Ucret<=0)
            {
                MessageBox.Show("Ücret değeri 0'dan küçük olamaz  !EROR! ");
            }
            else
            txtUcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_musteriler (MusteriAd,MusteriSoyad,Cinsiyet,Telefon,Mail,TC,OdaNumarasi,Ucret,GirisTarihi,CikisTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p5", txtMail.Text);
                komut.Parameters.AddWithValue("@p6", txtTCkimlik.Text);
                komut.Parameters.AddWithValue("@p7", txtOdaNumarasi.Text);
                komut.Parameters.AddWithValue("@p8", txtUcret.Text);
                komut.Parameters.AddWithValue("@p9", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p10", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn101.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda101 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn102.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn103.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn104.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda104 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn105.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda105 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn106.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda106 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn107.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda107 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn108.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda108 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = btn109.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda109 (adi,soyadi) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            // Oda 101
            SqlCommand komut1 = new SqlCommand("SELECT * FROM oda101", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                btn101.Text = "101\n" + dr1["adi"].ToString() + " " + dr1["soyadi"].ToString();
            }
            dr1.Close(); // Okuyucuyu kapatmayı unutmayın.
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }

            // Oda 102
            SqlCommand komut2 = new SqlCommand("SELECT * FROM oda102", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                btn102.Text = "102\n" + dr2["adi"].ToString() + " " + dr2["soyadi"].ToString();
            }
            dr2.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            // Oda 103
            SqlCommand komut3 = new SqlCommand("SELECT * FROM oda103", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                btn103.Text = "103\n" + dr3["adi"].ToString() + " " + dr3["soyadi"].ToString();
            }
            dr3.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }

            // Oda 104
            SqlCommand komut4 = new SqlCommand("SELECT * FROM oda104", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                btn104.Text = "104\n" + dr4["adi"].ToString() + " " + dr4["soyadi"].ToString();
            }
            dr4.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }

            // Oda 105
            SqlCommand komut5 = new SqlCommand("SELECT * FROM oda105", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                btn105.Text = "105\n" + dr5["adi"].ToString() + " " + dr5["soyadi"].ToString();
            }
            dr5.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }

            // Oda 106
            SqlCommand komut6 = new SqlCommand("SELECT * FROM oda106", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                btn106.Text = "106\n" + dr6["adi"].ToString() + " " + dr6["soyadi"].ToString();
            }
            dr6.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }

            // Oda 107
            SqlCommand komut7 = new SqlCommand("SELECT * FROM oda107", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                btn107.Text = "107\n" + dr7["adi"].ToString() + " " + dr7["soyadi"].ToString();
            }
            dr7.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            // Oda 108
            SqlCommand komut8 = new SqlCommand("SELECT * FROM oda108", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                btn108.Text = "108\n" + dr8["adi"].ToString() + " " + dr8["soyadi"].ToString();
            }
            dr8.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            // Oda 109
            SqlCommand komut9 = new SqlCommand("SELECT * FROM oda109", baglanti);
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                btn109.Text = "109\n" + dr9["adi"].ToString() + " " + dr9["soyadi"].ToString();
            }
            dr9.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }

            baglanti.Close();
        }
    }
}


// Data Source-DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog-YesilVadiPansiyon; Integrated Security-True
