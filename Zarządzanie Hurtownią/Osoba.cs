using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public class Osoba
    {
        public int ID { get; set; }
        public string Imię {  get; set; }
        public string Nazwisko {  get; set; }
        public Adres Adres {  get; set; }
        public string NrTelefonu { get; set; }
        public int Godziny = 0;

        public Osoba(int id, string imię, string nazwisko, Adres adres, string nr_telefonu) 
        {
            ID = id;
            Imię = imię;
            Nazwisko = nazwisko;
            Adres = adres;
            NrTelefonu = nr_telefonu;
        }
    }
}
