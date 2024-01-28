using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarządzanie_Hurtownią
{
    public partial class OknoDodajProdukt : Form
    {
        public int idMagazynu;
        public int Kategoria;
        public OknoDodajProdukt(int magID)
        {
            InitializeComponent();
            idMagazynu = magID;

        }
        private void PrzyciskZapisz_Click(object sender, EventArgs e)
        {
            double cen = Convert.ToDouble(CenaTekst.Text, CultureInfo.InvariantCulture);
            List<Produkt> produkty = BazaDanych.PobierzProdukty();
            int maxId = produkty.Count > 0 ? produkty.Max(p => p.ID_Produktu) : 0;
            int idProd = maxId + 1;

            if (KategoriaCombo.Text == "Owoc")
            {
                Kategoria = 1;
            }
            else if (KategoriaCombo.Text == "Warzywo")
            {
                Kategoria = 2;
            }
            else if (KategoriaCombo.Text == "Produkt mleczny")
            {
                Kategoria = 3;
            }
            else if (KategoriaCombo.Text == "Słodycz")
            {
                Kategoria = 4;
            }
            else if (KategoriaCombo.Text == "Produkt zbożowy")
            {
                Kategoria = 5;
            }
            else if (KategoriaCombo.Text == "Przyprawa")
            {
                Kategoria = 6;
            }
            else if (KategoriaCombo.Text == "Ryba")
            {
                Kategoria = 7;
            }
            BazaDanych.DodawanieProduktu(idProd, Kategoria, idMagazynu, NazwaTekst.Text, cen, Convert.ToInt32(IloscTekst.Text));
            Close();
        }

        private void CenaTekst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }
    }
}
