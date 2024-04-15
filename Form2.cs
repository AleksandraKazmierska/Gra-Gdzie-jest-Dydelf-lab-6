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
    public partial class Form2 : Form
    {
        private Form3 ustawienia;
        private System.Windows.Forms.Timer timer;
        private int czasGry;
        private int liczbaDydelfow;
        private int liczbaKrokodyli;
        private int[,] plansza_gry;
        private Random rand;
        private DataGridView planszaDataGridView;
        public Form2(Form3 ustawienia)
        {
            InitializeComponent();
            this.ustawienia = ustawienia;
            czasGry = ustawienia.CzasGry;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick_2;
            timer.Start();
            liczbaDydelfow = ustawienia.LiczbaDydelfow;
            liczbaKrokodyli = ustawienia.LiczbaKrokodyli;

            rand = new Random();
            planszaDataGridView = plansza;
            InicjalizujPlansze();
            RozmiescDydelfyIKrokodyle();

            planszaDataGridView.CellClick += plansza_CellClick;
        }

        private void plansza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell clickedCell = planszaDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (clickedCell.Tag != null && clickedCell.Tag.ToString() == "Revealed")
            {
                return;
            }

            switch (plansza_gry[e.RowIndex, e.ColumnIndex])
            {
                case 0:
                    clickedCell.Value = " ";
                    break;
                case 1:
                    clickedCell.Value = "D"; 
                    break;
                case 2:
                    clickedCell.Value = "K"; 
                    KoniecGry(false); 
                    return;
            }

            clickedCell.Tag = "Revealed";

            SprawdzKoniecGry();

        }

        private void InicjalizujPlansze()
        {
            plansza_gry = new int[ustawienia.RozmiarX, ustawienia.RozmiarY];
            planszaDataGridView.RowCount = ustawienia.RozmiarX;
            planszaDataGridView.ColumnCount = ustawienia.RozmiarY;

            
        }

        private void RozmiescDydelfyIKrokodyle()
        {
            int liczbaKomorek = ustawienia.RozmiarX * ustawienia.RozmiarY;

            int liczbaDydelfow_i_Korkodyli = liczbaDydelfow + liczbaKrokodyli;

            if (liczbaDydelfow_i_Korkodyli > liczbaKomorek)
            {
                MessageBox.Show("Za dużo krokodli i dydelfów na rozmiar tablicy!");
                return;
            }

            for (int i = 0; i < ustawienia.RozmiarX; i++)
            {
                for (int j = 0; j < ustawienia.RozmiarY; j++)
                {
                    plansza_gry[i, j] = 0; 
                }
            }

            for (int i = 0; i < liczbaDydelfow; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(ustawienia.RozmiarX);
                    y = rand.Next(ustawienia.RozmiarY);
                } while (plansza_gry[x, y] != 0); 
                plansza_gry[x, y] = 1; 
            }

            for (int i = 0; i < liczbaKrokodyli; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(ustawienia.RozmiarX);
                    y = rand.Next(ustawienia.RozmiarY);
                } while (plansza_gry[x, y] != 0); 
                plansza_gry[x, y] = 2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }



        private void plansza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SprawdzKoniecGry()
        {
            int pozostaleDydelfy = 0;

            for (int i = 0; i < ustawienia.RozmiarX; i++)
            {
                for (int j = 0; j < ustawienia.RozmiarY; j++)
                {
                    if (plansza_gry[i, j] == 1 && planszaDataGridView.Rows[i].Cells[j].Tag == null)
                    {
                        pozostaleDydelfy++;
                    }
                }
            }

            if (pozostaleDydelfy == 0)
            {
                KoniecGry(true); 
            }
        }

        private void KoniecGry(bool wygrana)
        {
            timer.Stop(); 
            if (wygrana)
            {
                MessageBox.Show("Wygrywasz!");
            }
            else
            {
                MessageBox.Show("Trafiłeś na krokodyla! Przegrywasz.");
            }
            this.Close(); 
        }

        private void odliczanie_czasu_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            czasGry--;
            odliczanie_czasu.Text = $"Czas: {czasGry} s";

            if (czasGry <= 0)
            {
                timer.Stop();
                MessageBox.Show("Koniec czasu! Przegrałeś.");
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
