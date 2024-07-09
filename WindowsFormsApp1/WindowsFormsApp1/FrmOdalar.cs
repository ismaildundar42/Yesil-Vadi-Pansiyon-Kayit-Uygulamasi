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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");
        private void FrmOdalar_Load(object sender, EventArgs e)
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
            }

            baglanti.Close();

        }
    }
}
