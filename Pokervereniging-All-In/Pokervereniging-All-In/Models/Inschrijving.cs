using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public class Inschrijving : Event        
    {
        public int Ecode { get; set; }
        public int Volgnummer { get; set; }
        public int Pcode { get; set; }
        public bool HeeftBetaald { get; set; }

        public Inschrijving(int e_code, int volgnummer, int pcode, bool heeftbetaald)
        {
            Ecode = e_code;
            Volgnummer = volgnummer;
            Pcode = pcode;
            HeeftBetaald = heeftbetaald;
        }

        public override string ToString()
        {
            return Ecode.ToString();
        }
    }
}
