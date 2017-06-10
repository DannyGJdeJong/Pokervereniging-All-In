using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class MasterclassController : DatabaseController
    {
        public void Insertmasterclass(Masterclass masterclass)
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO masterclass (e_code, minimale_rating, bekende_speler) VALUES (@e_code, @minimale_rating, @bekende_speler)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter ECodeParam = new MySqlParameter("@e_code", MySqlDbType.Int32);
                MySqlParameter MinRatingParam = new MySqlParameter("@minimale_rating", MySqlDbType.Int32);
                MySqlParameter BekendeSpelerParam = new MySqlParameter("@bekende_speler", MySqlDbType.Int32);

                ECodeParam.Value = masterclass.E_code;
                MinRatingParam.Value = masterclass.Minimale_rating;
                BekendeSpelerParam.Value = masterclass.Bekende_speler;

                cmd.Parameters.Add(ECodeParam);
                cmd.Parameters.Add(MinRatingParam);
                cmd.Parameters.Add(BekendeSpelerParam);

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
        public List<Masterclass> GetMasterclasses()
        {
            List<Masterclass> masterclasses = new List<Masterclass>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM masterclass";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int EventCode = dataReader.GetInt32("e_code");
                    int MinRating = dataReader.GetInt32("minimale_rating");
                    int BekendeSpeler = dataReader.GetInt32("bekende_speler");
                    Masterclass masterclass = new Masterclass { E_code = EventCode, Bekende_speler = BekendeSpeler, Minimale_rating = MinRating };

                    masterclasses.Add(masterclass);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van Masterclass mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return masterclasses;
        }
    }
}

