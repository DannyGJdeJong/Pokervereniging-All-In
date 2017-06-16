using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    public class SpelerController : DatabaseController
    {
        public Speler GetSpeler(int pcode)
        {
            Speler speler = null;
            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler WHERE p_code = @pcode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);

                MySqlParameter pcodeParam = new MySqlParameter("@pcode", MySqlDbType.Int32);
                pcodeParam.Value = pcode;

                cmd.Parameters.Add(pcodeParam);
                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    speler = GetAttributes(dataReader);
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
                    spelers.Add(GetAttributes(dataReader));
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

        public void UpdateSpeler(Speler speler)
        {
            try
            {
                conn.Open();
                string updateString = "UPDATE speler SET roepnaam = @roepnaam, voorletters = @voorletters, tussenvoegsels = @tussenvoegsels, achternaam = @achternaam, geslacht = @geslacht, postcode = @postcode, straat = @straat, huisnummer = @huisnummer, woonplaats = @woonplaats, emailadres = @emailadres, IBAN_nummer = @IBAN_nummer, rating = @rating, staat_op_blacklist = @staat_op_blacklist WHERE p_code = @p_code";

                MySqlCommand cmdUpdateSpeler = new MySqlCommand(updateString, conn);

                MySqlParameter pcodeParam = new MySqlParameter("@p_code", MySqlDbType.Int32) { Value = speler.P_Code };
                MySqlParameter roepnaamParam = new MySqlParameter("@roepnaam", MySqlDbType.VarChar) { Value = speler.Roepnaam };
                MySqlParameter voorlettersParam = new MySqlParameter("@voorletters", MySqlDbType.VarChar) { Value = speler.Voorletters };
                MySqlParameter tussenvoegselsParam = new MySqlParameter("@tussenvoegsels", MySqlDbType.VarChar) { Value = speler.Tussenvoegsels };
                MySqlParameter achternaamParam = new MySqlParameter("@achternaam", MySqlDbType.VarChar) { Value = speler.Achternaam };
                MySqlParameter geslachtParam = new MySqlParameter("@geslacht", MySqlDbType.VarChar) { Value = speler.Geslacht };
                MySqlParameter postcodeParam = new MySqlParameter("@postcode", MySqlDbType.VarChar) { Value = speler.Postcode };
                MySqlParameter straatParam = new MySqlParameter("@straat", MySqlDbType.VarChar) { Value = speler.Straat };
                MySqlParameter huisnummerParam = new MySqlParameter("@huisnummer", MySqlDbType.Int32) { Value = speler.Huisnummer };
                MySqlParameter woonplaatsParam = new MySqlParameter("@woonplaats", MySqlDbType.VarChar) { Value = speler.Woonplaats };
                MySqlParameter emailadresParam = new MySqlParameter("@emailadres", MySqlDbType.VarChar) { Value = speler.Emailadres };
                MySqlParameter IBANParam = new MySqlParameter("@IBAN_nummer", MySqlDbType.VarChar) { Value = speler.IBANnummer };
                MySqlParameter ratingParam = new MySqlParameter("@rating", MySqlDbType.Int32) { Value = speler.Rating };
                MySqlParameter staatOpBlacklistParam = new MySqlParameter("@staat_op_blacklist", MySqlDbType.VarChar) { Value = speler.StaatOpBlacklist ? 'J' : 'N' };

                cmdUpdateSpeler.Parameters.Add(pcodeParam);
                cmdUpdateSpeler.Parameters.Add(roepnaamParam);
                cmdUpdateSpeler.Parameters.Add(voorlettersParam);
                cmdUpdateSpeler.Parameters.Add(tussenvoegselsParam);
                cmdUpdateSpeler.Parameters.Add(achternaamParam);
                cmdUpdateSpeler.Parameters.Add(geslachtParam);
                cmdUpdateSpeler.Parameters.Add(postcodeParam);
                cmdUpdateSpeler.Parameters.Add(straatParam);
                cmdUpdateSpeler.Parameters.Add(huisnummerParam);
                cmdUpdateSpeler.Parameters.Add(woonplaatsParam);
                cmdUpdateSpeler.Parameters.Add(emailadresParam);
                cmdUpdateSpeler.Parameters.Add(IBANParam);
                cmdUpdateSpeler.Parameters.Add(ratingParam);
                cmdUpdateSpeler.Parameters.Add(staatOpBlacklistParam);

                cmdUpdateSpeler.Prepare();

                cmdUpdateSpeler.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Speler> GetSpelersByRating()
        {
            List<Speler> spelers = new List<Speler>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler ORDER BY rating DESC";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    spelers.Add(GetAttributes(dataReader));
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


        private Speler GetAttributes(MySqlDataReader dataReader)
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

            return new Speler(p_code, roepnaam, voorletters, tussenvoegsels, achternaam, geslacht, postcode, straat, huisnummer, woonplaats, emailadres, IBAN_nummer, rating, staat_op_blacklist);

        }
    }
}
