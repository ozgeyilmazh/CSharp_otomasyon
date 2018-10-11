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
    public partial class satisgorevlisi : Form
    {
        public satisgorevlisi()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void malzeme_alis_Click(object sender, EventArgs e)
        {
            SMalzemeAlis Sma = new SMalzemeAlis();
            Sma.Show();
            this.Hide();
        }

        private void urun_satis_Click(object sender, EventArgs e)
        {
            AUrunSatim us = new AUrunSatim();
            us.Show();
            this.Hide();
        }
    }
}
