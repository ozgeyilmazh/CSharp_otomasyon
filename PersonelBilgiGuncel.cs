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
    public partial class PersonelBilgiGuncel : Form
    {
        public PersonelBilgiGuncel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Personel cl = new Personel();
            cl.Show();
            this.Hide();

        }
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");
        private void PersonelBilgiGuncel_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu1 = "Select * From personel where 1";

            MySqlCommand cmd = new MySqlCommand(sorgu1, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_pers.Items.Add(dr["per_ad_soyad"]);

            }
            conn.Close();

            conn.Open();
            string sorgu2 = "Select * From pozisyon where 1";

            MySqlCommand cmd2 = new MySqlCommand(sorgu2, conn);
            cmd2.CommandType = CommandType.Text;
            MySqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                cmb_poz.Items.Add(dr2["gorev"]);

            }
            conn.Close();

        }

        private void cmb_pers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_pers.SelectedIndex.ToString() != "")
            {
                
                conn.Open();
                string sorgu = "SELECT * FROM personel WHERE per_ad_soyad = @cmb";
                object a = cmb_pers.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@cmb", MySqlDbType.String).Value = a;
                MySqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                {
                    per_ad_soyad.Text = dr2["per_ad_soyad"].ToString();
                    per_tc.Text = dr2["per_tc"].ToString();
                    per_tel.Text = dr2["per_tel"].ToString();
                    per_email.Text = dr2["per_email"].ToString();
                    per_adres.Text = dr2["per_adres"].ToString();
                    cmb_poz.Text = dr2["per_pozisyon"].ToString();
                    per_maas.Text = dr2["per_maas"].ToString();
                }
                conn.Close();

                cmb_pers.ResetText();
            }
        }

        private void btn_deg1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_ad_soyad='" + per_ad_soyad.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_tc='" + per_tc.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_tel='" + per_tel.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg4_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_email='" + per_email.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg5_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_adres='" + per_adres.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg7_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_maas='" + per_maas.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_deg6_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update personel set per_pozisyon='" + cmb_poz.Text + "' where per_tc=" + per_tc.Text + "";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
