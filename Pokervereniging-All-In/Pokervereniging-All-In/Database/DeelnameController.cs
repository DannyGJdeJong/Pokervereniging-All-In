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
    }
}
