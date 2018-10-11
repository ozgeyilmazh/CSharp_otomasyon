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
using MySql.Web;
namespace ProfeTasarimDeneme
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int hak = 3;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
                    if (k_adi.Text.ToString() == "" || k_sifre.Text.ToString() == "")
                    {
                        MessageBox.Show("Boşlukları lütfen doldurunuz.!");
                    }

            else
            {
                String Kullanici = k_adi.Text;
                String sifre = k_sifre.Text;

                if (Kullanici == "yonetici" && sifre == "123")
                {
                    Categories kategori = new Categories();
                    kategori.Show();
                    this.Hide();
                }
              
                else if (Kullanici == "stokgorevlisi" && sifre == "456")
                {                    
                    stokgorevlisi s = new stokgorevlisi();
                    s.Show();
                    this.Hide();
                }

                else if (Kullanici == "satisgorevlisi" && sifre == "789")
                            {  
                                satisgorevlisi sg2 = new satisgorevlisi();
                                sg2.Show();
                                this.Hide();
                            }

                else
                {
                    hak--;
                    MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz.! Kalan hakkınız: " + hak);
                }
    
                if (hak == 0) Application.Exit();


            }
                   
        }
    }
}
