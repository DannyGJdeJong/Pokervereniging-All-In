using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Masterclass
    {
        public int Bekende_speler { get; set; }
        public int E_code { get; set; }
        public int Minimale_rating { get; set; }

        public override string ToString()
        {
            return String.Format("{0} (e_code = {1}) {minimale ratting = {2}}", Bekende_speler, E_code, Minimale_rating);
        }
    }
}
