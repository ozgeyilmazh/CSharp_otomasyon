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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
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

        private void Stok_Load(object sender, EventArgs e)
        {

        }
    }
}
