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
    public partial class AUrunSatim : Form
    {
        public AUrunSatim()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");
  

        private void btn_ekle6_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat6.Text);
            int b = Int32.Parse(n6.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_cam.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n6.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_cam.ResetText();
            fiyat6.Clear();
            n6.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                kmt.Connection = conn;
                kmt.CommandText = "DELETE FROM urunsatis WHERE fatura_no=@fat_no";
                kmt.Parameters.AddWithValue("@fat_no", dgw_urun.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM urunsatis ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_urun.DataSource = ds.Tables[0];
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            conn.Open();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            satisgorevlisi sg = new satisgorevlisi();
            sg.Show();
            this.Hide();
        }

        private void btn_ekle5_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (urun, musteri, miktar, fiyat, tarih) values (@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat5.Text);
            int b = Int32.Parse(n5.Value.ToString());

            int fiyat = a * b;

            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@urun", cmb_plastik.SelectedItem);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n5.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_plastik.ResetText();
            fiyat5.Clear();
            n5.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle4_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat4.Text);
            int b = Int32.Parse(n4.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_maden.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n4.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_maden.ResetText();
            fiyat4.Clear();
            n4.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no, @urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat3.Text);
            int b = Int32.Parse(n3.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_palet.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n3.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_palet.ResetText();
            fiyat3.Clear();
            n3.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle2_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat2.Text);
            int b = Int32.Parse(n2.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_demir.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n2.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_demir.ResetText();
            fiyat2.Clear();
            n2.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat1.Text);
            int b = Int32.Parse(n1.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_kagit.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n1.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_kagit.ResetText();
            fiyat1.Clear();
            n1.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From urunsatim where urun like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }
    }
}
