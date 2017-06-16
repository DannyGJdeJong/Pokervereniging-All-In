using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public class Deelname      
    {
        public int Ecode { get; set; }
        public int Volgnummer { get; set; }
        public int Rondenr { get; set; }
        public bool Doetnogmee { get; set; }
        public int Tafelnummer { get; set; }

        public Deelname(int e_code, int volgnummer, int rondenr, bool doetnogmee, int tafelnummer)
        {
            Ecode = e_code;
            Volgnummer = volgnummer;
            Rondenr = rondenr;
            Doetnogmee = doetnogmee;
            Tafelnummer = tafelnummer;
        }

        public override string ToString()
        {
            return Ecode.ToString();
        }
    }
}
