using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSistemi
{
    public partial class Yonetici_CalisanYonetimi : Form
    {
        public Yonetici_CalisanYonetimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            yonetici_calisanYonetimiUserControl myControl = new yonetici_calisanYonetimiUserControl();
            panel1.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;

        }

        private void calisanListele_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            yonetici_calisanListeleUserControl myControl = new yonetici_calisanListeleUserControl();
            panel1.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            yoneticiEkrani yoneticiEkrani = new yoneticiEkrani();
            yoneticiEkrani.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            yoneticiEkrani gerı = new yoneticiEkrani();
            gerı.Show();
            this.Close();
        }
    }
}
