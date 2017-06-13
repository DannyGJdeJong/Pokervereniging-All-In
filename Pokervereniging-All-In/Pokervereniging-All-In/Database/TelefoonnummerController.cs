using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class TelefoonnummerController : DatabaseController
    {
        public List<string> GetTelefoonnummers(int p_code)
        {
            List<string> telefoonnummers = new List<string>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM speler_telefoonnummer WHERE p_code = @p_code";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter p_codeParam = new MySqlParameter("@p_code", MySqlDbType.Int32);
                p_codeParam.Value = p_code;

                cmd.Parameters.Add(p_codeParam);
                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    telefoonnummers.Add(dataReader.GetString("telefoonnummer"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to " + e);
                throw e;
            }
            finally
            {
                conn.Close();
            }

            return telefoonnummers;
        }
    }
}
