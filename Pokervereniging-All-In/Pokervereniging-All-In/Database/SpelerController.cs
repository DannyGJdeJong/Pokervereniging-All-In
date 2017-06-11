using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class SpelerController : DatabaseController
    {
        public List<Speler> GetSpelers()
        {
            List<Speler> spelers = new List<Speler>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int p_code = dataReader.GetInt32("p_code");
                    string roepnaam = dataReader.GetString("roepnaam");
                    string voorletters = dataReader.GetString("voorletters");
                    string tussenvoegsels = dataReader[3] as string;
                    string achternaam = dataReader.GetString("achternaam");
                    char geslacht = dataReader.GetChar("geslacht");
                    string postcode = dataReader.GetString("postcode");
                    string straat = dataReader.GetString("straat");
                    int huisnummer = dataReader.GetInt32("huisnummer");
                    string woonplaats = dataReader.GetString("woonplaats");
                    string emailadres = dataReader.GetString("emailadres");
                    string IBAN_nummer = dataReader.GetString("IBAN_nummer");
                    int rating = dataReader.GetInt32("rating");
                    bool staat_op_blacklist = dataReader.GetChar("staat_op_blacklist") == 'J';

                    Speler speler = new Speler();
                    speler.P_Code = p_code;
                    speler.Roepnaam = roepnaam;
                    speler.Voorletters = voorletters;
                    speler.Tussenvoegsels = tussenvoegsels;
                    speler.Achternaam = achternaam;
                    speler.Geslacht = geslacht;
                    speler.Postcode = postcode;
                    speler.Straat = straat;
                    speler.Huisnummer = huisnummer;
                    speler.Woonplaats = woonplaats;
                    speler.Emailadres = emailadres;
                    speler.IBANnummer = IBAN_nummer;
                    speler.Rating = rating;
                    speler.StaatOpBlacklist = staat_op_blacklist;
                    TelefoonnummerController telnumCont = new TelefoonnummerController();
                    speler.Telefoonnummers = telnumCont.GetTelefoonnummers(p_code);
                    spelers.Add(speler);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong when trying to " + ex);
            }
            finally
            {
                conn.Close();
            }

            return spelers;
        }
    }
}
