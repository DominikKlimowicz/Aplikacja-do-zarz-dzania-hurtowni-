using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarządzanie_Hurtownią
{
    public partial class OknoMagazyn : Form
    {
        private int MagazynID;
        private List<Produkt> produktyMag;
        public OknoMagazyn(Magazyn mag)
        {
            produktyMag = PobierzProdukty();

            InitializeComponent();

            this.Text = mag.Nazwa;
            label1.Text = mag.Nazwa;
            MagazynID = mag.ID;

            InformacjaProdukty();
            Dodawanie();
            InformacjaIlosc();

            PobierzProdukty();
        }

        private List<Produkt> PobierzProdukty()
        {
            List<Produkt> produkty = BazaDanych.PobierzProdukty();
            produktyMag =  new List<Produkt>();
            foreach (Produkt produkt in produkty)
            {
                if (produkt.ID_Magazynu == MagazynID)
                {
                    produktyMag.Add(produkt);
                    LabelNazwa(produkt.Nazwa, produkt.Ilość);
                    PoleTekstowe(produkt.Nazwa);
                }
            }
            return produktyMag;
        }

        public void LabelNazwa(string nazwa, int ilosc)
        {
            string tekst = $"{nazwa} --- {ilosc}";

            TableLayoutPanel pomoc = new TableLayoutPanel();
            pomoc.Name = nazwa + "Panel";
            pomoc.AutoSize = true;

            Label label = new Label
            {
                Text = tekst,
                Name = nazwa + "Label",
                AutoSize = true,
                Font = new Font("Calibri", 16),
                //Dock = DockStyle.Left,
                BorderStyle = BorderStyle.FixedSingle
            };

            ElementInfo info = new ElementInfo { Nazwa = nazwa, Ilość = ilosc };
            label.Tag = info;
            pomoc.Controls.Add(label);
            Button przycisk = new Button
            {
                Height = 32,
                Text = "Usuń",
                Name = nazwa + "Usun",
                Dock = DockStyle.Right,
            };

            przycisk.Click += (sender, e) =>
            {
                // Tutaj umieść kod obsługi usuwania, używając informacji związanej z etykietą
                // Możesz na przykład uzyskać nazwę etykiety, dzięki której znajdziesz odpowiadający element do usunięcia
                UsunElement(nazwa);
            };
            pomoc.Controls.Add(przycisk);

            PanelProdukty.Controls.Add(pomoc);

        }

        private void InformacjaProdukty()
        {
            string tekst = "NAZWA --- ILOŚĆ W MAGAZYNIE";

            Label label = new Label
            {
                Text = tekst,
                AutoSize = true,
                Font = new Font("Calibri", 16),
                Dock = DockStyle.Left,
                ForeColor = Color.DarkGreen,
                //BorderStyle = BorderStyle.FixedSingle
            };

            PanelProdukty.Controls.Add(label);
        }

        private void Dodawanie()
        {
            Button przycisk = new Button
            {
                Text = "Dodaj produkt",
                AutoSize = true,
                Dock = DockStyle.Right,
                Name = "Dodanie"
            };

            przycisk.Click += (sender, e) =>
            {
                DodajProdukt();
            };
            PanelProdukty.Controls.Add(przycisk);
        }

        private void InformacjaIlosc()
        {
            string tekst = "NOWA ILOŚĆ";

            Label label = new Label
            {
                Text = tekst,
                AutoSize = true,
                Font = new Font("Calibri", 16),
                Dock = DockStyle.Left,
                ForeColor = Color.Red,
            };

            PanelEdycja.Controls.Add(label);
        }

        private void DodajProdukt()
        {
            //OknoDodajProdukt okienko = new OknoDodajProdukt(MagazynID);
            //okienko.Show();
        }

        private void PoleTekstowe(string nazwa)
        {
            NumericTextBox tekst = new NumericTextBox
            {
                Width = 417,
                Font = new Font("Calibri", 12),
                PlaceholderText = nazwa,
                Name = nazwa + "Tekst"
            };
            PanelEdycja.Controls.Add(tekst);
        }

        private void Klikniecie(object sender, EventArgs e)
        {
            foreach (Control control in PanelEdycja.Controls)
            {
                if (control is TextBox && control.Text != null)
                {
                    NumericTextBox textBox = (NumericTextBox)control;
                    string nazwa = textBox.Name;
                    string zawartosc = textBox.Text;
                    if (zawartosc.Length == 0)
                    {
                        MessageBox.Show("Puste pole.");
                    }
                    else
                    {
                        //MessageBox.Show($"Pole: {nazwa};\n Napis: {zawartosc}");
                        foreach (Control cont in PanelProdukty.Controls)
                        {
                            //MessageBox.Show(cont.Name);
                            if (cont is TableLayoutPanel)
                            {
                                foreach (Control c in cont.Controls)
                                {
                                    if (c is Label)
                                    {
                                        ElementInfo info = (ElementInfo)c.Tag;
                                        PanelProdukty.Controls.Remove(cont);
                                        LabelNazwa(info.Nazwa, Convert.ToInt32(zawartosc));
                                        textBox.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void UsunElement(string nazwaElementu)
        {
            foreach (Control control in PanelProdukty.Controls)
            {
                if (control is TableLayoutPanel tableLayoutPanel && control.Name == nazwaElementu + "Panel")
                {
                    PanelProdukty.Controls.Remove(control);
                    //Label label = tableLayoutPanel.Controls[0] as Label;
                    //if (label != null && label.Text.StartsWith(nazwaElementu))
                    //{
                    //    PanelProdukty.Controls.Remove(tableLayoutPanel);
                    //    break;
                    //}
                }
            }
            foreach (Control control in PanelEdycja.Controls)
            {
                if (control is TextBox tekst && control.Name == (nazwaElementu + "Tekst"))
                {
                    PanelEdycja.Controls.Remove(control);
                }
            }
        }
        private void PrzesylDoBazy(object sender, EventArgs e)
        {
            foreach (Control ctrl in PanelProdukty.Controls)
            {
                if (ctrl is TableLayoutPanel) 
                {
                    foreach(Control control in ctrl.Controls)
                    {
                        if (control is Label)
                        {
                            ElementInfo infor = (ElementInfo)control.Tag;
                            if (infor != null)
                            {
                                MessageBox.Show($"Nazwa: {infor.Nazwa}; Ilość: {Convert.ToInt32(infor.Ilość)}");
                                foreach (Produkt p in produktyMag)
                                {
                                    if (p.Nazwa == infor.Nazwa)
                                    {
                                        MessageBox.Show($"P.nazwa: {p.Nazwa}\nP.ilosc: {p.Ilość}\n infor.Nazwa: {infor.Nazwa}\ninfor.ilosc: {infor.Ilość}");
                                        p.Ilość = Convert.ToInt32(infor.Ilość);
                                        MessageBox.Show($"P.nazwa: {p.Nazwa}\nP.ilosc: {p.Ilość}\n infor.Nazwa: {infor.Nazwa}\ninfor.ilosc: {infor.Ilość}\n ID Magazynu: {p.ID_Magazynu}");
                                        BazaDanych.AktualizacjaProduktow(p.Nazwa, p.Ilość, p.ID_Magazynu);
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
