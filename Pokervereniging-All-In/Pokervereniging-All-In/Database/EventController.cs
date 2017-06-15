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
                    Event Temp_Event = new Event(eventCode, datum, Locatie);
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

        public Event GetEvent(int ecode)
        {
            Event Temp_Event = null;

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM event WHERE e_code = @ecode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);

                EcodeParam.Value = ecode;

                cmd.Parameters.Add(EcodeParam);

                cmd.Prepare();

                while (dataReader.Read())
                {
                    int e_code = dataReader.GetInt32("e_code");
                    DateTime datum = dataReader.GetDateTime("datum");
                    int lcode = dataReader.GetInt32("l_code");

                    Temp_Event = new Event(ecode, datum, lcode);                    
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

            return Temp_Event;
        }
    }
}
