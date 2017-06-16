using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    public class DeelnameController : DatabaseController
    {
        public List<Deelname> GetDeelnames(int ecode)
        {
            List<Deelname> Deelnames = new List<Deelname>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM deelname WHERE e_code = @ecode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                EcodeParam.Value = ecode;
                cmd.Parameters.Add(EcodeParam);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                ToernooiController TC = new ToernooiController();

                while (dataReader.Read())
                {
                    int e_code = dataReader.GetInt32("e_code");  
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
            int nummer = 0;
            foreach (KeyValuePair<Speler, Inschrijving> kv in toernooi.Inschrijvingen)
            {
                if (kv.Key.Geslacht == 'v' && kv.Value.HeeftBetaald)
                {
                    nummer++;
                    InsertDeelname(new Deelname(toernooi.E_code, kv.Value.Volgnummer, 1, true, nummer % toernooi.Locatie.Aantal_tafels));
                }
            }
            foreach (KeyValuePair<Speler, Inschrijving> kv in toernooi.Inschrijvingen)
            {
                if (kv.Key.Geslacht == 'm' && kv.Value.HeeftBetaald)
                {
                    nummer++;
                    InsertDeelname(new Deelname(toernooi.E_code, kv.Value.Volgnummer, 1, true, nummer % toernooi.Locatie.Aantal_tafels));
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

                ECodeParam.Value = deelname.Ecode;
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
