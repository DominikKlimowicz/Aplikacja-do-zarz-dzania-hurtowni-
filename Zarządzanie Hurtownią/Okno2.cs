using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zarządzanie_Hurtownią
{
    public partial class Okno2 : Form
    {
        public Okno2()
        {
            InitializeComponent();
            Text = "Kraina Świeżych Smaków";
            Ods.Start();

            listBox1.MouseClick += new MouseEventHandler(listBox1_Wybieranie);
            listBox2.MouseClick += new MouseEventHandler(listBox2_Wybieranie);
            listBox3.MouseClick += new MouseEventHandler(listBox3_Wybieranie);
        }

        private void listBox1_Wybieranie(object sender, MouseEventArgs e)
        {
            List<Magazyn> magazyny = BazaDanych.PobierzMagazyny();
            int index = listBox1.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                Magazyn wybrana = magazyny[index];
                OknoMag okienko = new OknoMag(wybrana);
                okienko.Show();
            }
        }

        private void listBox2_Wybieranie(object sender, MouseEventArgs e)
        {
            List<Klient> klienci = BazaDanych.PobierzKlientow();
            int index = listBox2.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string nazwa = listBox2.Items[index].ToString();
                foreach (Klient k in klienci)
                {
                    if(nazwa == k.NazwaFirmy)
                    {
                        OknoKlient okienko = new OknoKlient(k);
                        okienko.Show();
                    }
                }
            }
        }

        private void listBox3_Wybieranie(object sender, MouseEventArgs e)
        {
            List<Osoba> pracownicy = BazaDanych.PobierzPracownikow();
            int index = listBox3.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string nazwa = listBox3.Items[index].ToString();
                foreach(Osoba osoba in pracownicy)
                {
                    if(nazwa == osoba.Imię + " " + osoba.Nazwisko)
                    {
                        OknoPracownik okienko = new OknoPracownik(osoba);
                        okienko.Show();
                    }
                }
            }
        }

        private void DodawanieMagazynow()
        {
            List<Magazyn> nazwy = BazaDanych.PobierzMagazyny();

            foreach (Magazyn n in nazwy)
            {
                if (!listBox1.Items.Contains(n.Nazwa))
                {
                    listBox1.Items.Add(n.Nazwa);
                }
            }
        }
        private void DodawanieKlientow()
        {
            List<Klient> klienci = BazaDanych.PobierzKlientow();

            foreach (Klient k in klienci)
            {
                if (!listBox2.Items.Contains(k.NazwaFirmy))
                {
                    listBox2.Items.Add(k.NazwaFirmy);
                }
            }
        }
        private void DodawaniePracowników()
        {
            List<Osoba> pracownicy = BazaDanych.PobierzPracownikow();

            foreach (Osoba pracownik in pracownicy)
            {
                if (!listBox3.Items.Contains(pracownik.Imię + " " + pracownik.Nazwisko))
                {
                    listBox3.Items.Add(pracownik.Imię + " " + pracownik.Nazwisko);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodawanieMKP okno = new DodawanieMKP();
            okno.Show();
        }

        private void Ods_Tick(object sender, EventArgs e)
        {
            DodawanieMagazynow();
            DodawanieKlientow();
            DodawaniePracowników();
            Ods.Enabled = false;
            Ods.Enabled = true;
        }

        private void Okno2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
