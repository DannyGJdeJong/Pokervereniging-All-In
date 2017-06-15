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
        public int Mindeelnemers { get; set; }
        public int Inleggeld { get; set; }
        public Speler Eersteplaats { get; set; }
        public Speler Tweedeplaats { get; set; }
        public Speler Derdeplaats { get; set; }
        public Dictionary<Speler, Deelname> Inschrijvingen { get; set; }

        public Toernooi(int e_code, int mindeelnemers, int inleggeld, Speler eersteplaats = null, Speler tweedeplaats = null, Speler derdeplaats = null )
        {
            SortedPlayerController SC = new SortedPlayerController();

            E_code = e_code;
            Mindeelnemers = mindeelnemers;
            Inleggeld = inleggeld;
            Eersteplaats = eersteplaats;
            Tweedeplaats = tweedeplaats;
            Derdeplaats = derdeplaats;
            Inschrijvingen = SC.GetSpelersAndDeelnames(E_code);
        }

        public override string ToString()
        {
            return E_code.ToString();
        }
    }
}
