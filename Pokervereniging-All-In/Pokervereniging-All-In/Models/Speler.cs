using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    public class Speler : Persoon
    {
        public string IBANnummer { get; set; }
        public int Rating { get; set; }
        public bool StaatOpBlacklist { get; set; }
        public List<string> Telefoonnummers { get; set; }

        public Speler(int p_code, string roepnaam, string voorletters, string tussenvoegsels, string achternaam, char geslacht, string postcode, string straat, int huisnummer, string woonplaats, string emailadres, string IBAN_nummer, int rating, bool staat_op_blacklist)
        {
            P_Code = p_code;
            Roepnaam = roepnaam;
            Voorletters = voorletters;
            Tussenvoegsels = tussenvoegsels;
            Achternaam = achternaam;
            Geslacht = geslacht;
            Postcode = postcode;
            Straat = straat;
            Huisnummer = huisnummer;
            Woonplaats = woonplaats;
            Emailadres = emailadres;
            IBANnummer = IBAN_nummer;
            Rating = rating;
            StaatOpBlacklist = staat_op_blacklist;
            TelefoonnummerController telnumCont = new TelefoonnummerController();
            Telefoonnummers = telnumCont.GetTelefoonnummers(P_Code);
        }

        public Speler()
        {
            P_Code = -1;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Tussenvoegsels))
            {
                return Roepnaam + " " + Achternaam;
            }
            else
            {
                return Roepnaam + " " + Tussenvoegsels + " " + Achternaam;
            }
        }
    }
}
