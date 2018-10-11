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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Personel cl = new Personel();
            cl.Show();
            this.Hide();

        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu1 = "Select * From pozisyon where 1";

            MySqlCommand cmd = new MySqlCommand(sorgu1, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_poz.Items.Add(dr["gorev"]);
            }
            conn.Close();

        }
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");

        public void function1()
        {

            string sql = "INSERT INTO personel (per_ad_soyad, per_tc, per_tel, per_email, per_adres, per_pozisyon, per_maas) values (@per_ad_soyad,@per_tc,@per_tel,@per_email,@per_adres,@per_pozisyon,@per_maas)";

            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@per_ad_soyad", per_ad_soyad.Text);
            Lcmd.Parameters.AddWithValue("@per_tc", per_tc.Text);
            Lcmd.Parameters.AddWithValue("@per_tel", per_tel.Text);
            Lcmd.Parameters.AddWithValue("@per_email", per_email.Text);
            Lcmd.Parameters.AddWithValue("@per_adres", per_adres.Text);
            Lcmd.Parameters.AddWithValue("@per_pozisyon", cmb_poz.SelectedItem);
            Lcmd.Parameters.AddWithValue("@per_maas", per_maas.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            conn.Close();
            per_ad_soyad.Clear();
            per_tc.Clear();
            per_tel.Clear();
            per_email.Clear();
            per_adres.Clear();
            cmb_poz.ResetText();
            per_maas.Clear();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (per_ad_soyad.Text.ToString() == "" && per_tc.Text.ToString() == "" && per_tel.Text.ToString() == "" && per_email.Text.ToString() == "" && per_adres.Text.ToString() == "" && cmb_poz.SelectedItem.ToString()  == " " && per_maas.Text.ToString() == "")
            {

                MessageBox.Show("Boşlukları lütfen doldurunuz.!");
            }
            else
            {
                function1();
            }
        }
    }
}
