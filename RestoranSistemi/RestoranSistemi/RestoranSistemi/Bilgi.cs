﻿using System;
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
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form1 nesnesini oluşturuyoruz
            Form1 anaForm = new Form1();

            // Form1'i gösteriyoruz
            anaForm.Show();

            // Mevcut formu kapatıyoruz
            this.Close();
        }
    }
}
