using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProfeTasarimDeneme
{
    public partial class musteriler : Form
    {
        public musteriler()
        {
            InitializeComponent();
        }

        private void musteriler_Load(object sender, EventArgs e)
        {

        }

        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");

        public void function1()
        {

            string sql = "INSERT INTO musteri (must_ad_soyad, must_telefon, must_email, must_adres) values (@must_ad_soyad,@must_telefon,@must_email,@must_adres)";

            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@must_ad_soyad", must_ad_soyad.Text);
            Lcmd.Parameters.AddWithValue("@must_telefon", must_telefon.Text);
            Lcmd.Parameters.AddWithValue("@must_email", must_email.Text);
            Lcmd.Parameters.AddWithValue("@must_adres", must_adres.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM musteri ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_musteri.DataSource = ds.Tables[0];
            conn.Close();
            must_ad_soyad.Clear();
            must_email.Clear();
            must_telefon.Clear();
            must_adres.Clear();
            MessageBox.Show("Kayıt Eklendi");
        }

        public void function2(string veri)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_musteri.DataSource = ds.Tables[0];
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (must_ad_soyad.Text.ToString() == "" && must_telefon.Text.ToString() == "" && must_email.Text.ToString() == "" && must_adres.Text.ToString() == "")
            {

                MessageBox.Show("Boşlukları lütfen doldurunuz.!");
            }
            else
            {
                function1();
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM musteri";
            function2(sql);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                kmt.Connection = conn;
                kmt.CommandText = "DELETE FROM musteri WHERE must_ad_soyad=@musteri";
                kmt.Parameters.AddWithValue("@musteri", dgw_musteri.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM musteri ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_musteri.DataSource = ds.Tables[0];
            }
          }

        private void btn_ara_Click(object sender, EventArgs e)
        {

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From musteri where must_ad_soyad like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_musteri.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }
    }
}
