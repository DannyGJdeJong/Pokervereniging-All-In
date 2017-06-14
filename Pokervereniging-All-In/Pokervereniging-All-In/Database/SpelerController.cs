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

                    Speler speler = new Speler(p_code, roepnaam, voorletters, tussenvoegsels, achternaam, geslacht, postcode, straat, huisnummer, woonplaats, emailadres, IBAN_nummer, rating, staat_op_blacklist);
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

        public Speler GetSpeler(int pcode)
        {
            Speler speler = null;
            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler WHERE p_code = @pcode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlParameter pcodeParam = new MySqlParameter("@pcode", MySqlDbType.Int32);
                pcodeParam.Value = pcode;

                cmd.Parameters.Add(pcodeParam);
                cmd.Prepare();

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

                    speler = new Speler(p_code, roepnaam, voorletters, tussenvoegsels, achternaam, geslacht, postcode, straat, huisnummer, woonplaats, emailadres, IBAN_nummer, rating, staat_op_blacklist);
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

            return speler;
        }
    }
}
