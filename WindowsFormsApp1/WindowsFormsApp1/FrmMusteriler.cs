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
using System.Data.Sql;


namespace WindowsFormsApp1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6M1J8AO\\SQLEXPRESS;Initial Catalog=YesilVadiPansiyon;Integrated Security=True;");

        public void bilgileriGoster()
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_musteriler",baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                // veri yapısı mantığında ekleme nesnesi oluşturduk kök ve subitemleri olan
               ListViewItem ekle = new ListViewItem();

                ekle.Text = dr["MusteriId"].ToString();
                ekle.SubItems.Add(dr["MusteriAd"].ToString());
                ekle.SubItems.Add(dr["MusteriSoyad"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNumarasi"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                // oluşturulan itemleri listviewe ekliyoruz
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          // bilgileriGoster();
        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            bilgileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTCkimlik.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarasi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           if(txtOdaNumarasi.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNumarasi.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show(id + " id'li müşteri çıkışı başarıyla yapılmıştır.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtOdaNumarasi.Text = "";
            txtTCkimlik.Text = "";
            txtTelefon.Text = "";
            txtUcret.Text = "";
            cmbCinsiyet.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tbl_musteriler set MusteriAd=@p1,MusteriSoyad=@p2,Cinsiyet=@p3,Telefon=@p4,Mail=@p5,TC=@p6,OdaNumarasi=@p7,Ucret=@p8,GirisTarihi=@p9,CikisTarihi=@p10 where MusteriId=@p11", baglanti);
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", txtTCkimlik.Text);
            komut.Parameters.AddWithValue("@p7", txtOdaNumarasi.Text);
            komut.Parameters.AddWithValue("@p8", txtUcret.Text);
            komut.Parameters.AddWithValue("@p9", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p10", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@p11", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(id + " ID'li müşteri bilgileri güncellendi");
            bilgileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_musteriler where MusteriSoyad like @p1",baglanti);
            komut.Parameters.AddWithValue("@p1", "%" + txtAranacakSoyad.Text + "%");
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                // veri yapısı mantığında ekleme nesnesi oluşturduk kök ve subitemleri olan
               ListViewItem ekle = new ListViewItem();

                ekle.Text = dr["MusteriId"].ToString();
                ekle.SubItems.Add(dr["MusteriAd"].ToString());
                ekle.SubItems.Add(dr["MusteriSoyad"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNumarasi"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                // oluşturulan itemleri listviewe ekliyoruz
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
/*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM tbl_musteriler where MusteriId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(id + " ID'li müşteri veri tabanından silindi.");
            bilgileriGoster();
*/