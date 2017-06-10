using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class Speler : Persoon
    {
        public string IBANnummer { get; set; }
        public int Rating { get; set; }
        public bool StaatOpBlacklist { get; set; }
        public List<string> Telefoonnummers { get; set; }

        public Speler()
        {

        }
    }
}
