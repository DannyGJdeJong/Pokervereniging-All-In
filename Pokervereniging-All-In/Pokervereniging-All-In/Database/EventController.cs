using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Models
{
    class EventController : DatabaseController
    {
        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM event";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int eventCode = dataReader.GetInt32("e_code");
                    DateTime datum  = dataReader.GetDateTime("datum");
                    int Locatie = dataReader.GetInt32("l_code");
                    Event Temp_Event = new Event { E_code = eventCode, Datum = datum, L_code = Locatie };
                    events.Add(Temp_Event);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van event mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return events;
        }
        public void InsertEvent(Event e)
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO event (datum, l_code) VALUES (@datum, @lcode)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter datumParam = new MySqlParameter("@datum", MySqlDbType.Date);
                MySqlParameter l_codeParam = new MySqlParameter("@lcode", MySqlDbType.Int32);

                datumParam.Value = e.Datum;
                l_codeParam.Value = e.L_code;
 

                cmd.Parameters.Add(datumParam);
                cmd.Parameters.Add(l_codeParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Masterclass niet toegeveogd: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public int GetEventID(EventController e)
        {
           int  Temp_Ecode = 0;
            foreach (Event value in e.GetEvents())
            {
                Temp_Ecode = Math.Max(value.E_code, Temp_Ecode);
            }
            return Temp_Ecode;
        }
    }
}
