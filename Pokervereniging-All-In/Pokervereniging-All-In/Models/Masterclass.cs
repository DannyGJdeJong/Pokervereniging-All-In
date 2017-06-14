using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Masterclass
    {

        public int E_code { get; set; }
        public int Minimale_rating { get; set; }
        public BekendeSpeler Bekende_Speler = new BekendeSpeler();

    }
}
