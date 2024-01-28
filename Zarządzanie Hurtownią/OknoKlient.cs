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
    public partial class OknoKlient : Form
    {
        Klient k;
        int kliknięcia;
        public OknoKlient(Klient klient)
        {
            InitializeComponent();
            k = klient;
            Text = "Klient " + k.Imię + " " + k.Nazwisko;
            WczytanieDanych();
        }
        private void WczytanieDanych()
        {
            ImieNazwisko.Text = k.Imię + " " + k.Nazwisko;
            NazwaFirmy.Text = k.NazwaFirmy;
            Miasto.Text = k.Adres.Miasto;
            Ulica.Text = k.Adres.Ulica;
            NrBudynku.Text = k.Adres.Numer_Lokalu;
            Email.Text = k.Email;
            NrTelefonu.Text = k.NrTelefonu;
            Fax.Text = k.Fax;
        }
        private void PrzyciskEdytuj_Click(object sender, EventArgs e)
        {
            kliknięcia += 1;
            if (kliknięcia % 2 == 0)
            {
                PanelEdycja.Enabled = false;
                ImieBox.Enabled = false;
                NazwiskoBox.Enabled = false;
                NazwaBox.Enabled = false;
                MiastoBox.Enabled = false;
                UlicaBox.Enabled = false;
                BudBox.Enabled = false;
                EmailBox.Enabled = false;
                TelBox.Enabled = false;
                FaxBox.Enabled = false;
                PrzyciskZapisz.Enabled = false;
            }
            else
            {
                PanelEdycja.Enabled = true;
                ImieBox.Enabled = true;
                NazwiskoBox.Enabled = true;
                NazwaBox.Enabled = true;
                MiastoBox.Enabled = true;
                UlicaBox.Enabled = true;
                BudBox.Enabled = true;
                EmailBox.Enabled = true;
                TelBox.Enabled = true;
                FaxBox.Enabled = true;
                PrzyciskZapisz.Enabled = true;
            }
        }

        private void PrzyciskZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                k.Imię = ImieBox.Text;
                k.Nazwisko = NazwiskoBox.Text;
                k.NazwaFirmy = NazwaBox.Text;
                k.Adres.Miasto = MiastoBox.Text;
                k.Adres.Ulica = UlicaBox.Text;
                k.Adres.Numer_Lokalu = BudBox.Text;
                k.Email = EmailBox.Text;
                k.NrTelefonu = TelBox.Text;
                k.Fax = FaxBox.Text;
                BazaDanych.AktualizacjaKlienta(k);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wykryto błąd: {ex}");
            }
        }

        private void PrzyciskUsun_Click(object sender, EventArgs e)
        {
            BazaDanych.UsunKlienta(k);
            Close();
        }
    }
}
