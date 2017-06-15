using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class DeelnameController : DatabaseController
    {
        public List<Deelname> GetDeelnames()
        {
            List<Deelname> Deelnames = new List<Deelname>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM toernooi";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                ToernooiController TC = new ToernooiController();

                while (dataReader.Read())
                {
                    Toernooi e_code = TC.GetToernooi(dataReader.GetInt32("e_code"));     
                    int volgnummer = dataReader.GetInt32("volgnummer");
                    int rondenr = dataReader.GetInt32("ronde_nr");
                    bool doetnogmee = dataReader.GetString("doet_nog_mee") == "J";
                    int tafelnummer = dataReader.GetInt32("tafelnummer");

                    Deelname deelname = new Deelname(e_code, volgnummer, rondenr, doetnogmee, tafelnummer);
                    Deelnames.Add(deelname);
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

            return Deelnames;
        }

        public void InsertDeelnames(int ecode)
        {
            ToernooiController TC = new ToernooiController();
            Toernooi toernooi = TC.GetToernooi(ecode);
            foreach (KeyValuePair<Speler, int> kv in toernooi.Inschrijvingen)
            {
                int nummer = 0;
                if (kv.Key.Geslacht == 'v')
                {
                    nummer++;
                    InsertDeelname(new Deelname(toernooi, kv.Value, 1, true, nummer % toernooi.Locatie.Aantal_tafels + 1));
                }
            }
            foreach (KeyValuePair<Speler, int> kv in toernooi.Inschrijvingen)
            {
                int nummer = 0;
                if (kv.Key.Geslacht == 'm')
                {
                    nummer++;
                    InsertDeelname(new Deelname(toernooi, kv.Value, 1, true, nummer & toernooi.Locatie.Aantal_tafels + 1));
                }
            }
        }

        public void InsertDeelname(Deelname deelname)
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO deelname (e_code, volgnummer, ronde_nr, doet_nog_mee, tafelnummer) 
                                        VALUES (@e_code, @volgnummer, @rondenr, @doetnogmee, @tafelnummer)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter ECodeParam = new MySqlParameter("@e_code", MySqlDbType.Int32);
                MySqlParameter VolgnummerParam = new MySqlParameter("@volgnummer", MySqlDbType.Int32);
                MySqlParameter RondenrParam = new MySqlParameter("@rondenr", MySqlDbType.Int32);
                MySqlParameter DoetnogmeeParam = new MySqlParameter("@doetnogmee", MySqlDbType.VarChar);
                MySqlParameter TafelnummerParam = new MySqlParameter("@tafelnummer", MySqlDbType.Int32);

                ECodeParam.Value = deelname.Ecode.E_code;
                VolgnummerParam.Value = deelname.Volgnummer;
                RondenrParam.Value = deelname.Rondenr;
                DoetnogmeeParam.Value = deelname.Doetnogmee == true ? "J" : "N";
                TafelnummerParam.Value = deelname.Tafelnummer;

                cmd.Parameters.Add(ECodeParam);
                cmd.Parameters.Add(VolgnummerParam);
                cmd.Parameters.Add(RondenrParam);
                cmd.Parameters.Add(DoetnogmeeParam);
                cmd.Parameters.Add(TafelnummerParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Toernooi niet toegeveogd: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
