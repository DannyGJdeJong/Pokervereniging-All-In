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
        public int Mindeelnemers { get; set; }
        public int Inleggeld { get; set; }
        public Speler Eersteplaats { get; set; }
        public Speler Tweedeplaats { get; set; }
        public Speler Derdeplaats { get; set; }

        public Inschrijving(int e_code, int mindeelnemers, int inleggeld, Speler eersteplaats = null, Speler tweedeplaats = null, Speler derdeplaats = null )
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
            return Ecode.ToString();
        }
    }
}
