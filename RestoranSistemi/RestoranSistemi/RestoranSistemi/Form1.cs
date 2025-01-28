namespace RestoranSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisYapClick(object sender, EventArgs e)
        {
            // Form2'yi aç
            Form2 yeniForm = new Form2();
            yeniForm.Show(); // Form2'yi yeni bir pencere olarak göster
            this.Hide();

        }

        private void kayıtOlClick(object sender, EventArgs e)
        {
            // Form3'yi aç
            Form3 yeniForm = new Form3();
            yeniForm.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bilgilen_Click(object sender, EventArgs e)
        {
            // Bilgi formunun bir örneğini oluşturun.
            Bilgi bilgiFormu = new Bilgi();

            // Yeni formu gösterin.
            bilgiFormu.Show();
        }
    }
}
