using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public class Locatie
    {
        public int Aantal_tafels { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public int L_code { get; set; }
        public string Plaats { get; set; }
        public string Postcode { get; set; }

        public Locatie(int aantaltafels, string straat, int huisnummer, int lcode, string plaats, string postcode)
        {
            Aantal_tafels = aantaltafels;
            Straat = straat;
            Huisnummer = huisnummer;
            L_code = lcode;
            Plaats = plaats;
            Postcode = postcode;
        }

        public Locatie()
        {

        }

        public override string ToString()
        {
            return Plaats;
        }
    }

}
