using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public class Klient : Osoba
    {
        public string Email { get; set; }
        public string NazwaFirmy { get; set; }
        public string Fax { get; set; }

        public Klient(int id, string imię, string nazwisko, Adres adres, string nr_telefonu, string email, string nazwaFirmy, string fax)
             : base(id, imię, nazwisko, adres, nr_telefonu)
        {
            Email = email;
            NazwaFirmy = nazwaFirmy;
            Fax = fax;
        }
    }
}
