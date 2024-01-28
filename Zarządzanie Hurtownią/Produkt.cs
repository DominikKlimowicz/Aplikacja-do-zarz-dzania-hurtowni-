using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public class Produkt
    {
        public int ID_Produktu { get; set; }
        public int ID_Magazynu { get; set; }
        public string Nazwa { get; set; }
        public int Ilość {  get; set; }
        public double Cena_Za_Jednostkę { get; set; }

        public Produkt(int id_produktu, int id_magazynu, string nazwa, int ilosc, double cena_za_jednostke) 
        {
            ID_Produktu = id_produktu;
            ID_Magazynu = id_magazynu;
            Nazwa = nazwa;
            Ilość = ilosc;
            Cena_Za_Jednostkę = cena_za_jednostke;
        }
    }
}
