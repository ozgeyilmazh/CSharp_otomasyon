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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");

 
        private void button2_Click(object sender, EventArgs e)
        {    
            conn.Open();
            string veri = "SELECT fatura_no,tarih,fiyat FROM giderler";
           
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_gider.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string veri = "SELECT fatura_no,tarih,fiyat FROM urunsatis";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_gelir.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT fatura_no,tarih,fiyat FROM urunsatis WHERE tarih Like '%" + dateTimePicker1.Text + "%'", conn);
            MySqlCommand cmd2 = new MySqlCommand("SELECT fatura_no,tarih,fiyat FROM giderler WHERE tarih Like  '%" + dateTimePicker1.Text + "%'", conn);
            cmd.Parameters.AddWithValue("@Tarih1",dateTimePicker1.Text);
            cmd2.Parameters.AddWithValue("@Tarih1", dateTimePicker1.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            da.Fill(ds);
            da2.Fill(ds2);
            dgw_gelir.DataSource = ds.Tables[0];
            dgw_gider.DataSource = ds2.Tables[0];
            conn.Close();

        }
    }
}
