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
    public partial class calisanEkrani : Form
    {
        public calisanEkrani()
        {
            InitializeComponent();
        }

        private void calisanEkrani_Load(object sender, EventArgs e)
        {
            lblHosgeldiniz.Text = $"HOŞGELDİNİZ  {globalVariables.AdminName}";
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            Calisan_AktifSiparisler aktifSiparisler = new Calisan_AktifSiparisler();
            aktifSiparisler.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOzet_Click(object sender, EventArgs e)
        {
            Calisan_SiparisOzeti siparisOzeti = new Calisan_SiparisOzeti();
            siparisOzeti.Show();
            this.Close();
        }
    }
}
