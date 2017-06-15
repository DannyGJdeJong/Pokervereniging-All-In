using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public class Masterclass : Event
    {
        public int Minimale_rating { get; set; }
        public BekendeSpeler Bekende_Speler = new BekendeSpeler();

        public Masterclass()
        {
            Locatie = new Locatie();
        }
    }
}
