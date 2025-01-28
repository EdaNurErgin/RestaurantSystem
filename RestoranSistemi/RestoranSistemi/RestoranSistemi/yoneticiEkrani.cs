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
    public partial class yoneticiEkrani : Form
    {
        public yoneticiEkrani()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yonetici_CalisanYonetimi yonetici_CalisanYonetimi = new Yonetici_CalisanYonetimi();
            yonetici_CalisanYonetimi.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yoneticiEkrani_Load(object sender, EventArgs e)
        {
            label2.Text = $"HOŞGELDİNİZ {globalVariables.AdminName}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yonetici_MenuYonetimi yonetici_MenuYonetimi = new Yonetici_MenuYonetimi();
            yonetici_MenuYonetimi.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yonetici_RaporSistemi yonetici_RaporSistemi = new Yonetici_RaporSistemi();
            yonetici_RaporSistemi.Show();
            this.Close();
        }
    }
}
