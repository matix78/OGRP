using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGRP__Okienkowy_Generator_Rozkazów_Pisemnych
{
    public partial class Form1 : Form
    {
        public string wybór;
        public static DateTime Today { get; }
        public Form1()
        {
            InitializeComponent();
            WynikTxt.Text = "";
        }

        private void Numer_Pociągu_txt(object sender, EventArgs e)
        {
            Wynik_txt(sender, e);
        }
        public void Wynik_txt(object sender, EventArgs e)
        {
            string Wynik = "";
            string WybórRozkazu = wybór;

            DateTime thisDate = DateTime.Today;

            if (NumerPociąguTxt.TextLength <= 0)
            {
                WynikTxt.Clear();
                return;
            }

            WynikTxt.Clear();


            Wynik = "Rozkaz pisemny " + WybórRozkazu + " nr " + NumerRozkazuTxt.Text + " dla pociągu " + NumerPociąguTxt.Text + " dnia " + thisDate.ToString("dd.MM.yyyy" + "r.");
            WynikTxt.AppendText(Wynik);


        }

        private void Numer_Rozkazu_txt(object sender, EventArgs e)
        {
            Wynik_txt(sender, e);
        }

        private void Numer_Pociągu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numer_Rozkazu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Rozkaz_SClick(object sender, EventArgs e)
        {
            Działka1Txt.Clear();
            Działka2Txt.Clear();
            Działka3Txt.Clear();
            Działka4Txt.Clear();
            wybór = "S";
            Działka1Txt.Text = "Zezwalam po otrzymaniu sygnału nakaz jazdy/tylko tego rozkazu pisemnego przyjechać obok wskazującego sygnał stój semafora wyjazdowego(uzupełnij).";
            Działka2Txt.Text = "Pominięcie sygnału Stój przy wjeździe/na semaforze odstępowym/wjazd z toru zamkniętego bez semafora.";
            Działka3Txt.Text = "Unieważnienie SBL";
            Działka4Txt.Text = "Inne";
            Wynik_txt(sender, e);
        }

        private void Rozkaz_OClick(object sender, EventArgs e)
        {
            Działka1Txt.Clear();
            Działka2Txt.Clear();
            Działka3Txt.Clear();
            Działka4Txt.Clear();
            wybór = "O";
            Wynik_txt(sender, e);
        }

        private void Rozkaz_NClick(object sender, EventArgs e)
        {
            Działka1Txt.Clear();
            Działka2Txt.Clear();
            Działka3Txt.Clear();
            Działka4Txt.Clear();
            wybór = "N";
            Wynik_txt(sender, e);
        }
    }
}
