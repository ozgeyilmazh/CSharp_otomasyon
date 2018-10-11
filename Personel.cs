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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PersonelEkle pe = new PersonelEkle();
            pe.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PersonelBilgiGuncel pbg = new PersonelBilgiGuncel();
            pbg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            conn.Open();

            string veri = "SELECT * FROM personel ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_per.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                kmt.Connection = conn;
                kmt.CommandText = "DELETE FROM personel WHERE per_ad_soyad=@per_ad_soyad";
                kmt.Parameters.AddWithValue("@per_ad_soyad", dgw_per.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM personel ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_per.DataSource = ds.Tables[0];
            }

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From personel where per_ad_soyad like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_per.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }
    }
}
