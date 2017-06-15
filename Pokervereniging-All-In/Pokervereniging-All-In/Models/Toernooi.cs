using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Toernooi : Event        
    {
        public int Ecode { get; set; }
        public int Mindeelnemers { get; set; }
        public int Inleggeld { get; set; }
        public int Eersteplaats { get; set; }
        public int Tweedeplaats { get; set; }
        public int Derdeplaats { get; set; }

        public Toernooi(int e_code, int mindeelnemers, int inleggeld, int eersteplaats = null, int tweedeplaats = null, int derdeplaats = null )
        {
            Ecode = e_code;
            Mindeelnemers = mindeelnemers;
            Inleggeld = inleggeld;
            Eersteplaats = eersteplaats;
            Tweedeplaats = tweedeplaats;
            Derdeplaats = derdeplaats;
        }

        public override string ToString()
        {
            return E_code.ToString();
        }
    }
}
