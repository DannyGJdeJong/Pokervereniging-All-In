using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class LocatieController :DatabaseController
    {
        public List<Locatie> GetLocaties()
        {
            List<Locatie> locaties = new List<Locatie>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM Locatie";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int aantal_tafels = dataReader.GetInt32("aantal_tafels");
                    string adres = dataReader.GetString("straat");
                    int huisnummer = dataReader.GetInt32("huisnummer");
                    int lcode = dataReader.GetInt32("l_code");
                    string plaats = dataReader.GetString("plaats");
                    string postcode = dataReader.GetString("postcode");

                    Locatie locatie = new Locatie();
                    locatie.Aantal_tafels = aantal_tafels;
                    locatie.Adres = adres;
                    locatie.Huisnummer = huisnummer;
                    locatie.L_code = lcode;
                    locatie.Plaats = plaats;
                    locatie.Postcode = postcode;
                    locaties.Add(locatie);
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

            return locaties;
        
    }
        public int GetLCode(string adres)
        {
            int Temp_LCode = 0;
            foreach (Locatie value in GetLocaties())
            {
                if (adres == value.Adres)
                {
                    Temp_LCode = value.L_code;
                }
            }

                return Temp_LCode;
        }
        public void InsertLocatie()
        {

        }

        public Locatie GetLocatie(int lcode)
        {
            Locatie locatie = null; 

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM locatie WHERE l_code = @lcode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);                

                MySqlParameter lcodeParam = new MySqlParameter("@lcode", MySqlDbType.Int32);
                lcodeParam.Value = lcode;

                cmd.Parameters.Add(lcodeParam);
                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int aantaltafels = dataReader.GetInt32("aantal_tafels");
                    int huisnummer = dataReader.GetInt32("huisnummer");
                    string plaats = dataReader.GetString("plaats");
                    string postcode = dataReader.GetString("postcode");

                    locatie = new Locatie(aantaltafels, huisnummer, lcode, plaats, postcode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return locatie;
        }
    }
}
