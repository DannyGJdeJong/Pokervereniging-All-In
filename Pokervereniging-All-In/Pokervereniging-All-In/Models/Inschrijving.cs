using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Inschrijving        
    {
        public Toernooi Ecode { get; set; }
        public int Volgnummer { get; set; }
        public Speler Pcode { get; set; }
        public bool Heeftbetaald { get; set; }

        public Inschrijving(Toernooi ecode, int volgnummer, Speler pcode, bool heeftbetaald)
        {
            Ecode = ecode;
            Volgnummer = volgnummer;
            Pcode = pcode;
            Heeftbetaald = heeftbetaald;
        }

        public override string ToString()
        {
            return Ecode.ToString();
        }
    }
}
