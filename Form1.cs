namespace Gra_Gdzie_jest_Dydelf
{
    public partial class Form1 : Form
    {
        private Form3 ustawienia;
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_startu_Click(object sender, EventArgs e)
        {
            if (ustawienia != null) 
            {
                Form2 rozgrywka = new Form2(ustawienia);
                rozgrywka.ShowDialog();
            }
            else
            {
                MessageBox.Show("Najpierw otwórz okno ustawieñ!");
            }
        }

        private void przycisk_przekierowujacy_do_ustawien_Click(object sender, EventArgs e)
        {
            Form3 ustawienia = new Form3();
            ustawienia.ShowDialog();
        }

        private void przycisk_wysjcia_z_gry_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
