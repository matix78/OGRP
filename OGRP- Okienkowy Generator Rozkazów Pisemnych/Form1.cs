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

            if (NumerPociąguTxt.TextLength <= 0)
            {
                WynikTxt.Clear();
                return;
            }

            WynikTxt.Clear();


            Wynik = "Rozkaz pisemny " + WybórRozkazu + " nr " + NumerRozkazuTxt.Text + " dla pociągu " + NumerPociąguTxt.Text;
            WynikTxt.AppendText(Wynik);


        }

        private void Numer_Rozkazu_txt(object sender, EventArgs e)
        {
            Wynik_txt(sender, e);
        }

        private void Rozkaz_SClick(object sender, EventArgs e)
        {
            wybór = "S";
            Wynik_txt(sender, e);
        }

        private void Rozkaz_OClick(object sender, EventArgs e)
        {
            wybór = "O";
            Wynik_txt(sender, e);
        }

        private void Rozkaz_NClick(object sender, EventArgs e)
        {
            wybór = "N";
            Wynik_txt(sender, e);
        }
    }
}
