using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfeTasarimDeneme
{
    public partial class stokgorevlisi : Form
    {
        public stokgorevlisi()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stok_takip_Click(object sender, EventArgs e)
        {
            SStok s = new SStok();
            s.Show();
            this.Hide();
        }
    }
}
