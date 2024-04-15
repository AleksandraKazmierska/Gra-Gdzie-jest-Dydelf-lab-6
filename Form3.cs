using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Gdzie_jest_Dydelf
{
    public partial class Form3 : Form
    {
        public int RozmiarX { get; private set; }
        public int RozmiarY { get; private set; }
        public int LiczbaDydelfow { get; private set; }
        public int LiczbaKrokodyli { get; private set; }
        public int CzasGry { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_box_rozmiar_x_planszy_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_box_rozmiar_y_planszy_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_box_ile_dydelfow_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_box_ile_korkodyli_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_box_wpisanie_czasu_gry_TextChanged(object sender, EventArgs e)
        {

        }

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            if (SprawdzOgraniczenia())
            {
                RozmiarX = int.Parse(text_box_rozmiar_x_planszy.Text);
                RozmiarY = int.Parse(text_box_rozmiar_y_planszy.Text);
                LiczbaDydelfow = int.Parse(text_box_ile_dydelfow.Text);
                LiczbaKrokodyli = int.Parse(text_box_ile_korkodyli.Text);
                CzasGry = int.Parse(text_box_wpisanie_czasu_gry.Text);

                Form2 gra = new Form2(this);
                gra.ShowDialog();
            }
        }

        private bool SprawdzOgraniczenia()
        {
            if (!SprawdzRozmiarPlanszy() || !SprawdzLiczbeDydelfow() || !SprawdzLiczbeKrokodyli() || !SprawdzCzasGry())
                return false;

            return true;
        }

        private bool SprawdzRozmiarPlanszy()
        {
            int x, y;
            if (!int.TryParse(text_box_rozmiar_x_planszy.Text, out x) || !int.TryParse(text_box_rozmiar_y_planszy.Text, out y))
            {
                MessageBox.Show("Podano nieprawidłowe wartości dla rozmiaru planszy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (x < 3 || x > 10 || y < 3 || y > 10)
            {
                MessageBox.Show("Rozmiar planszy powinien mieścić się w przedziale od 3 do 10!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SprawdzLiczbeDydelfow()
        {
            int dydelfy;
            if (!int.TryParse(text_box_ile_dydelfow.Text, out dydelfy))
            {
                MessageBox.Show("Podano nieprawidłową wartość dla liczby dydelfów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dydelfy < 1 || dydelfy > 6)
            {
                MessageBox.Show("Liczba dydelfów powinna mieścić się w przedziale od 1 do 6!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SprawdzLiczbeKrokodyli()
        {
            int krokodyle;
            if (!int.TryParse(text_box_ile_korkodyli.Text, out krokodyle))
            {
                MessageBox.Show("Podano nieprawidłową wartość dla liczby krokodyli!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (krokodyle < 0 || krokodyle > 1)
            {
                MessageBox.Show("Liczba krokodyli powinna mieścić się w przedziale od 0 do 1!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SprawdzCzasGry()
        {
            int czas;
            if (!int.TryParse(text_box_wpisanie_czasu_gry.Text, out czas))
            {
                MessageBox.Show("Podano nieprawidłową wartość dla czasu gry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (czas < 10 || czas > 60)
            {
                MessageBox.Show("Czas gry powinien mieścić się w przedziale od 10 do 60 sekund!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
