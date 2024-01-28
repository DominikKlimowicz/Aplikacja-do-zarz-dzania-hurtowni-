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
    public partial class OknoMag : Form
    {
        private int MagID;
        private List<Produkt> Produkty = new List<Produkt>();
        private int ID_P;
        public OknoMag(Magazyn mag)
        {
            InitializeComponent();
            Text = mag.Nazwa;
            MagID = mag.ID;
            PobierzProdukty();
            DodanieProduktow();

        }
        private void PobierzProdukty()
        {
            List<Produkt> prd = BazaDanych.PobierzProdukty();
            foreach (Produkt produkt in prd)
            {
                if (produkt.ID_Magazynu == MagID)
                {
                    bool produktIstnieje = Produkty.Any(p => p.ID_Produktu == produkt.ID_Produktu);
                    if (!produktIstnieje)
                    {
                        Produkty.Add(produkt);
                    }
                }
            }
        }
        private void DodanieProduktow()
        {
            ListaProduktow.DisplayMember = "Nazwa";
            foreach (Produkt prod in Produkty)
            {
                bool produktIstnieje = ListaProduktow.Items.Cast<Produkt>().Any(p => p.ID_Produktu == prod.ID_Produktu);
                if (!produktIstnieje)
                {
                    ListaProduktow.Items.Add(prod);
                }
            }
        }

        private void ListaProduktow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ListaProduktow.SelectedIndex;
            if (ind != -1)
            {
                Produkt p = Produkty[ind];
                NazwaProduktu.Text = p.Nazwa;
                LabelIlosc.Text = p.Ilość.ToString();
                LabelCena.Text = p.Cena_Za_Jednostkę.ToString("N2") + " zł";
            }
            else
            {
                NazwaProduktu.Text = "";
                LabelCena.Text = "";
                LabelIlosc.Text = "";
            }
        }

        private void CheckEdycja_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = CheckEdycja.Checked;
            PrzyciskZapisz.Enabled = isChecked;
            flowLayoutPanel3.Enabled = isChecked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OknoDodajProdukt okienko = new OknoDodajProdukt(MagID);
            okienko.Show();
        }

        private void PrzyciskUsun_Click(object sender, EventArgs e)
        {
            int ind = ListaProduktow.SelectedIndex;
            try
            {
                Produkt pr = (Produkt)ListaProduktow.Items[ind];
                ListaProduktow.Items.Remove(pr);
                Produkty.Remove(pr);
                BazaDanych.UsunProdukt(pr);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Nie wybrano produktu do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania produktu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrzyciskZapisz_Click(object sender, EventArgs e)
        {
            int ind = ListaProduktow.SelectedIndex;
            try
            {
                Produkt pr = (Produkt)ListaProduktow.Items[ind];
                int ilosc = Convert.ToInt32(NowaIlosc.Text);
                if (!string.IsNullOrWhiteSpace(NowaCena.Text))
                {
                    double cena = Convert.ToDouble(NowaCena.Text);
                    BazaDanych.AktualizacjaProduktow(pr.Nazwa, ilosc, MagID, cena);
                    pr.Cena_Za_Jednostkę = cena;
                }
                else
                {
                    BazaDanych.AktualizacjaProduktow(pr.Nazwa, ilosc, MagID);
                }
                pr.Ilość = ilosc;
                ListaProduktow.ClearSelected();
                CheckEdycja.Checked = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono nieprawidłową wartość dla ilości i/lub ceny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizacji produktu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListaProduktow.ClearSelected();
            PobierzProdukty();
            DodanieProduktow();
        }

        private void NowaCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
    }
}