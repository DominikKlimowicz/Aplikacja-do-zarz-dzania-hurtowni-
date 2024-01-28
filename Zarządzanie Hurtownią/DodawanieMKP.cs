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
    public partial class DodawanieMKP : Form
    {
        public DodawanieMKP()
        {
            InitializeComponent();
        }

        private void MagSpr_CheckedChanged(object sender, EventArgs e)
        {
            if (MagSpr.Checked)
            {
                PanelMag.Enabled = true;
                DodajMag.Enabled = true;
                Text = "Dodawanie Magazynu";
            }
            else
            {
                PanelMag.Enabled = false;
                DodajMag.Enabled = false;
            }
        }

        private void KlientSpr_CheckedChanged(object sender, EventArgs e)
        {
            if (KlientSpr.Checked)
            {
                PanelKlient.Enabled = true;
                DodajKlient.Enabled = true;
                Text = "Dodawanie Klienta";
            }
            else
            {
                PanelKlient.Enabled = false;
                DodajKlient.Enabled = false;
            }
        }

        private void PracSpr_CheckedChanged(object sender, EventArgs e)
        {
            if (PracSpr.Checked)
            {
                PanelPrac.Enabled = true;
                DodajPrac.Enabled = true;
                Text = "Dodawanie Pracownika";
            }
            else
            {
                PanelPrac.Enabled = false;
                DodajPrac.Enabled = false;
            }
        }

        private void DodajMag_Click(object sender, EventArgs e)
        {
            int ID = BazaDanych.NajwiekszeMagazynID() + 1;
            string nazwa = NazwaMag.Text;
            string miasto = MiastoMag.Text;
            string ulica = UlicaMag.Text;
            string nrBud = NrBudynkuMag.Text;
            Adres adres = new Adres(miasto, ulica, nrBud);
            Magazyn mag = new Magazyn(ID, nazwa, adres);
            BazaDanych.DodawanieMagazynu(mag);
        }

        private void DodajKlient_Click(object sender, EventArgs e)
        {
            int ID = BazaDanych.NajwiekszeKlientID() + 1;
            string nazwa = NazwaKlient.Text;
            string imie = ImieKlient.Text;
            string nazwisko = NazwiskoKlient.Text;
            string miasto = MiastoKlient.Text;
            string ulica = UlicaKlient.Text;
            string nrBud = NrBudKlient.Text;
            string nrTel = NrTelKlient.Text;
            string email = EmailKlient.Text;
            string fax = FaxKlient.Text;
            Adres adres = new Adres(miasto, ulica, nrBud);
            Klient k = new Klient(ID, imie, nazwisko, adres, nrTel, email, nazwa, fax);
            BazaDanych.DodawanieKlienta(k);
        }

        private void DodajPrac_Click(object sender, EventArgs e)
        {
            int ID = BazaDanych.NajwiekszePracID() + 1;
            string imię = ImiePrac.Text;
            string nazwisko = NazwiskoPrac.Text;
            string miasto = MiastoPrac.Text;
            string ulica = UlicaPrac.Text;
            string nrBud = NrBudPrac.Text;
            string nrTel = NrTelPrac.Text;
            Adres adres = new Adres(miasto, ulica, nrBud);
            Osoba prac = new Osoba(ID, imię, nazwisko, adres, nrTel);
            BazaDanych.DodawaniePracownika(prac);
        }
    }
}
