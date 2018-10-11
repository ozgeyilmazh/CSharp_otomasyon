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
    public partial class SStok : Form
    {
        public SStok()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stokgorevlisi sg = new stokgorevlisi();
            sg.Show();
            this.Hide();
        }
    }
}
