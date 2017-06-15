using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class SortedPlayerController : DatabaseController
    {
        public Dictionary<Speler, int> GetSpelersAndVolgnummers(int ecode)
        {
            Dictionary<Speler, int> SpelersVolgnummers = new Dictionary<Speler,int>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM inschrijving i JOIN speler s on i.p_code = s.p_code WHERE e_code = @ecode";

                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);

                EcodeParam.Value = ecode;

                cmd.Parameters.Add(EcodeParam);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                ToernooiController TC = new ToernooiController();

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
                    int volgnummer = dataReader.GetInt32("volgnummer");

                    Speler s = new Speler(p_code, roepnaam, voorletters, tussenvoegsels, achternaam, geslacht, postcode, straat, huisnummer, woonplaats, emailadres, IBAN_nummer, rating, staat_op_blacklist);
                    SpelersVolgnummers.Add(s, volgnummer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van bekende locaties mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return SpelersVolgnummers;

        }

        public Dictionary<Speler, Deelname> GetSpelersAndDeelnames(int ecode)
        {
            Dictionary<Speler, Deelname> Deelnames = new Dictionary<Speler, Deelname>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM deelname d JOIN inschrijving i on d.volgnummer = i.volgnummer JOIN speler s on i.p_code = s.p_code JOIN inschrijving n on d.e_code = i.e_code";

                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);

                EcodeParam.Value = ecode;

                cmd.Parameters.Add(EcodeParam);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                ToernooiController TC = new ToernooiController();

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
                    Toernooi e_code = TC.GetToernooi(dataReader.GetInt32("e_code"));
                    int volgnummer = dataReader.GetInt32("volgnummer");
                    int rondenr = dataReader.GetInt32("ronde_nr");
                    bool doetnogmee = dataReader.GetString("doet_nog_mee") == "J";
                    int tafelnummer = dataReader.GetInt32("tafelnummer");

                    Speler s = new Speler(p_code, roepnaam, voorletters, tussenvoegsels, achternaam, geslacht, postcode, straat, huisnummer, woonplaats, emailadres, IBAN_nummer, rating, staat_op_blacklist);
                    Deelname d = new Deelname(e_code, volgnummer, rondenr, doetnogmee, tafelnummer);
                    Deelnames.Add(s, d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van bekende locaties mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return Deelnames;

        }
    }
}
