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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS; Initial Catalog=YesilVadiPansiyon; Integrated Security=True; TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_mesajlar (adsoyad,icerik) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj başarılı bir şekilde kaydedildi.");
            this.tbl_mesajlarTableAdapter.Fill(this.yesilVadiPansiyonDataSet4.tbl_mesajlar);
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yesilVadiPansiyonDataSet4.tbl_mesajlar' table. You can move, or remove it, as needed.
            this.tbl_mesajlarTableAdapter.Fill(this.yesilVadiPansiyonDataSet4.tbl_mesajlar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçili satırın indeksini al
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                // Seçili satırın hücre değerlerini al
                string textBoxValue = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                string richTextBoxValue = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                // Hücre değerlerini TextBox ve RichTextBox'a ata
                textBox1.Text = textBoxValue;
                richTextBox1.Text = richTextBoxValue;
             
            }
        }
    }
}
