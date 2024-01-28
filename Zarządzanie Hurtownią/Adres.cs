using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarządzanie_Hurtownią
{
    public class Adres
    {
        public string Miasto {  get; set; }
        public string Ulica {  get; set; }
        public string Numer_Lokalu {  get; set; }

        public Adres(string miasto, string ulica, string numer_lokalu) 
        {
            Miasto = miasto;
            Ulica = ulica;
            Numer_Lokalu = numer_lokalu;
        }
    }
}
