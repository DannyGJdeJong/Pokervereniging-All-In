using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class BekendeSpelerController : DatabaseController
    {
        public List<BekendeSpeler> GetBekendeSpeler()
        {
            List<BekendeSpeler> bekendespelers = new List<BekendeSpeler>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM bekende_speler";
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
                    DateTime geb_datum = dataReader.GetDateTime("geb_datum");
                    string nationaliteit = dataReader.GetString("nationaliteit");
                    

                    BekendeSpeler speler = new BekendeSpeler();
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
                    speler.Geb_datum = geb_datum;
                    speler.nationaliteit = nationaliteit;
                    bekendespelers.Add(speler);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van bekende speler mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return bekendespelers;
        }
        public int GetPCode(string BSpeler)
        {
            int Temp_Pcode = 0;
            foreach (BekendeSpeler speler in GetBekendeSpeler())
            {
                if (speler.Roepnaam == BSpeler)
                {
                    Temp_Pcode = speler.P_Code;
                    break;
                }
            }
            return Temp_Pcode;
        }

    }
}
