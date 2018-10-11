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
    public partial class gider : Form
    {
        public gider()
        {
            InitializeComponent();
        }

        private void gider_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");

        public void function1()
        {

            string sql = "INSERT INTO gider (Tarih, fatura_no, GunlukYemek, GunlukNakliye, PersonelMaas, Diger, Toplam) values (@Tarih,@fat_no,@GunlukYemek,@GunlukNakliye,@PersonelMaas,@Diger,@Toplam)";
            string sql2 = "INSERT INTO giderler (fatura_no, tarih, fiyat) values (@fat_no, @tarih,@fiyat)";

            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            MySqlCommand Lcmd2 = new MySqlCommand(sql2, conn);
            Lcmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@GunlukYemek", gunluk_yemek.Text);
            Lcmd.Parameters.AddWithValue("@GunlukNakliye", gunluk_nakliye.Text);
            Lcmd.Parameters.AddWithValue("@PersonelMaas", personel_maas.Text);
            Lcmd.Parameters.AddWithValue("@Diger", diger.Text);
            int a = Int32.Parse(gunluk_yemek.Text);
            int b = Int32.Parse(gunluk_nakliye.Text);
            int c = Int32.Parse(personel_maas.Text);
            int d = Int32.Parse(diger.Text);
            int toplam = a + b + c + d;
            Lcmd.Parameters.AddWithValue("@Toplam", toplam.ToString());
            Lcmd2.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd2.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
            Lcmd2.Parameters.AddWithValue("@fiyat", toplam.ToString());

            conn.Open();
            Lcmd.ExecuteNonQuery();
            Lcmd2.ExecuteNonQuery();
            string veri = "SELECT * FROM gider ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_gider.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            gunluk_yemek.Clear();
            gunluk_nakliye.Clear();
            personel_maas.Clear();
            diger.Clear();
            MessageBox.Show("Kayıt Eklendi");
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (gunluk_yemek.Text.ToString() == "" && gunluk_nakliye.Text.ToString() == "" && personel_maas.Text.ToString() == "" && diger.Text.ToString() == "")
            {

                MessageBox.Show("Boşlukları lütfen doldurunuz.!");
            }
            else
            {
                function1();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                MySqlCommand kmt2 = new MySqlCommand();
                kmt.Connection = conn;
                kmt2.Connection = conn;
                kmt.CommandText = "DELETE FROM gider WHERE fatura_no=@fat_no";
                kmt2.CommandText = "DELETE FROM giderler WHERE fatura_no=@fat_no";
                kmt.Parameters.AddWithValue("@fat_no", dgw_gider.CurrentRow.Cells[0].Value.ToString());
                kmt2.Parameters.AddWithValue("@fat_no", dgw_gider.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt2.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM gider ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_gider.DataSource = ds.Tables[0];
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            conn.Open();
            string veri = "SELECT * FROM gider ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_gider.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From gider where fatura_no like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_gider.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }
    }
}
