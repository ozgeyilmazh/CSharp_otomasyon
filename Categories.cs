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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UrunSatim us = new UrunSatim();
            us.Show();
            this.Hide();
        }

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Personel cl = new Personel();
            cl.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Stok s = new Stok();
            s.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gider gider = new gider();
            gider.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GelirGider gg = new GelirGider();
            gg.Show();
            this.Hide();
        }

        private void tedarikciler_Click(object sender, EventArgs e)
        {
            tedarikciler tedarik = new tedarikciler();
            tedarik.Show();
            this.Hide();

        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            musteriler must = new musteriler();
            must.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void malzeme_alis_Click(object sender, EventArgs e)
        {
            MalzemeAlis ma = new MalzemeAlis();
            ma.Show();
            this.Hide();
        }
    }
}
