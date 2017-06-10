using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class SpelerController : DatabaseController
    {
        public List<string> GetSpelers()
        {
            List<string> namen = new List<string>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string naam = dataReader.GetString("roepnaam");
                    namen.Add(naam);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van genres mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return namen;
        }
    }
}
