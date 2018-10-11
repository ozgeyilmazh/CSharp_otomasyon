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
using MySql.Data;
namespace ProfeTasarimDeneme
{
    public partial class tedarikciler : Form
    {
        public tedarikciler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tedarikciler_Load(object sender, EventArgs e)
        {

        }
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");
          
        public void function1()
        {
            
            string sql = "INSERT INTO tedarikci (ted_ad_soyad, ted_telefon, ted_email, ted_adres) values (@ted_ad_soyad,@ted_telefon,@ted_email,@ted_adres)";

                MySqlCommand Lcmd = new MySqlCommand(sql, conn);
                Lcmd.Parameters.AddWithValue("@ted_ad_soyad", ted_ad_soyad.Text);
                Lcmd.Parameters.AddWithValue("@ted_telefon", ted_telefon.Text);
                Lcmd.Parameters.AddWithValue("@ted_email", ted_email.Text);
                Lcmd.Parameters.AddWithValue("@ted_adres", ted_adres.Text);

                conn.Open();
                Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM tedarikci ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_tedarik.DataSource = ds.Tables[0];
            conn.Close();
            ted_ad_soyad.Clear();
            ted_adres.Clear();
            ted_email.Clear();
            ted_telefon.Clear();
            MessageBox.Show("Kayıt Eklendi");
        }

        public void function2(string veri)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_tedarik.DataSource = ds.Tables[0];
        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {


            if (ted_ad_soyad.Text.ToString() == "" && ted_telefon.Text.ToString() == "" && ted_email.Text.ToString() == "" && ted_adres.Text.ToString() == "")
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
            string sql = "SELECT * FROM tedarikci";
            function2(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                kmt.Connection = conn;
                kmt.CommandText = "DELETE FROM tedarikci WHERE ted_ad_soyad=@tedarik";
                kmt.Parameters.AddWithValue("@tedarik", dgw_tedarik.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM tedarikci ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_tedarik.DataSource = ds.Tables[0];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From tedarikci where ted_ad_soyad like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_tedarik.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
