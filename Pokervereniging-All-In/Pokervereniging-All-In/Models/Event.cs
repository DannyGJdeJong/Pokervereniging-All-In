using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokervereniging_All_In.Database;

namespace Pokervereniging_All_In.Models
{
    class Event
    {
        public int E_code { get; set; }
        public DateTime Datum { get; set; }
        public int L_code { get; set; }
        public Locatie Locatie { get; set;}

        public Event(int ecode, DateTime datum, int lcode)
        {
            E_code = ecode;
            Datum = datum;
            L_code = lcode;
            LocatieController LC = new LocatieController();
            Locatie = LC.GetLocatie(L_code);
        }

        public Event ()
        {

        }

    }
}
