using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public class Magazyn
    {
        public int ID { get; set; }
        public string Nazwa {  get; set; }
        public Adres Adres { get; set; }

        public Magazyn(int id, string nazwa, Adres adres) 
        {
            ID = id;
            Nazwa = nazwa;
            Adres = adres;
        }
    }
}
