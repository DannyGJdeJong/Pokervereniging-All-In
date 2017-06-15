using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Locatie
    {
        public int Aantal_tafels { get; set; }
        public string Adres { get; set; }
        public int Huisnummer { get; set; }
        public int L_code { get; set; }
        public string Plaats { get; set; }
        public string Postcode { get; set; }

        public Locatie(int aantaltafels, int huisnummer, int lcode, string plaats, string postcode)
        {
            Aantal_tafels = aantaltafels;
            Huisnummer = huisnummer;
            L_code = lcode;
            Plaats = plaats;
            Postcode = postcode;
        }

        public Locatie()
        {

        }
    }

}
