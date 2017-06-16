using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public abstract class Persoon
    {
        public string Naam { get
            {
                if (String.IsNullOrEmpty(Tussenvoegsels))
                {
                    return Roepnaam + " " + Achternaam;
                }
                else
                {
                    return Roepnaam + " " + Tussenvoegsels + " " + Achternaam;
                }
            }
        }

        public string Adres { get
            {
                return Straat + " " + Huisnummer + " " + Woonplaats;
            }
        }
        public string Roepnaam { get; set; }
        public string Voorletters { get; set; }
        public string Achternaam { get; set; }
        public string Tussenvoegsels { get; set; }
        public string Straat { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }
        public int Huisnummer { get; set; }
        public char Geslacht { get; set; }
        public string Emailadres { get; set; }
        public int P_Code { get; set; }
    }
}
