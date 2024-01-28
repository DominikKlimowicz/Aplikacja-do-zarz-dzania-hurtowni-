using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarządzanie_Hurtownią
{
    public partial class OknoPracownik : Form
    {
        private int kliknięcia;
        Osoba pracownik;
        public OknoPracownik(Osoba p)
        {
            InitializeComponent();
            pracownik = p;
            BazaDanych.DodajGodziny(p);

            WczytanieDanych();
        }
        private void WczytanieDanych()
        {
            Text = "Pracownik " + pracownik.Imię + " " + pracownik.Nazwisko;
            ImieNazwisko.Text = pracownik.Imię + " " + pracownik.Nazwisko;
            Miasto.Text = pracownik.Adres.Miasto;
            Ulica.Text = pracownik.Adres.Ulica;
            NrBudynku.Text = pracownik.Adres.Numer_Lokalu;
            NrTelefonu.Text = pracownik.NrTelefonu;
            Email.Text = pracownik.Imię + "." + pracownik.Nazwisko + ".hurt@gmail.com";
            Godziny.Text = pracownik.Godziny.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BazaDanych.UsunPracownika(pracownik);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kliknięcia += 1;
            if (kliknięcia % 2 == 0)
            {
                PanelNowe.Enabled = false;
                NoweImie.Enabled = false;
                NoweNazwisko.Enabled = false;
                NoweMiasto.Enabled = false;
                NowaUlica.Enabled = false;
                NowyNrBudynku.Enabled = false;
                NowyNrTel.Enabled = false;
                PrzyciskEdycjaZapisz.Enabled = false;
            }
            else
            {
                PanelNowe.Enabled = true;
                NoweImie.Enabled = true;
                NoweNazwisko.Enabled = true;
                NoweMiasto.Enabled = true;
                NowaUlica.Enabled = true;
                NowyNrBudynku.Enabled = true;
                NowyNrTel.Enabled = true;
                PrzyciskEdycjaZapisz.Enabled = true;
            }
        }

        private void PrzyciskEdycjaZapisz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoweImie.Text))
            {
                pracownik.Imię = NoweImie.Text;
            }
            if (!string.IsNullOrEmpty(NoweNazwisko.Text))
            {
                pracownik.Nazwisko = NoweNazwisko.Text;
            }
            if (!string.IsNullOrEmpty(NoweMiasto.Text))
            {
                pracownik.Adres.Miasto = NoweMiasto.Text;
            }
            if (!string.IsNullOrEmpty(NowaUlica.Text))
            {
                pracownik.Adres.Ulica = NowaUlica.Text;
            }
            if (!string.IsNullOrEmpty(NowyNrBudynku.Text))
            {
                pracownik.Adres.Numer_Lokalu = NowyNrBudynku.Text;
            }
            if (!string.IsNullOrEmpty(NowyNrTel.Text))
            {
                pracownik.NrTelefonu = NowyNrTel.Text;
            }
            WczytanieDanych();
            BazaDanych.AktualizacjaPracownika(pracownik);
        }

        private void PrzyciskDG_Click(object sender, EventArgs e)
        {
            int godz = Convert.ToInt32(GodzinyCyfr.Value);
            pracownik.Godziny += godz;
            BazaDanych.DodajGodzine(pracownik, godz);
            WczytanieDanych();
        }
    }
}
