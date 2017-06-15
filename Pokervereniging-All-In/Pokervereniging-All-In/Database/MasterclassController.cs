using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    public class MasterclassController : DatabaseController
    {
        public void Insertmasterclass(Masterclass masterclass)
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO masterclass (e_code, minimale_rating, bekende_speler) 
                                        VALUES (@e_code, @minimale_rating, @bekende_speler)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter ECodeParam = new MySqlParameter("@e_code", MySqlDbType.Int32);
                MySqlParameter MinRatingParam = new MySqlParameter("@minimale_rating", MySqlDbType.Int32);
                MySqlParameter BekendeSpelerParam = new MySqlParameter("@bekende_speler", MySqlDbType.Int32);

                ECodeParam.Value = masterclass.E_code;
                MinRatingParam.Value = masterclass.Minimale_rating;
                BekendeSpelerParam.Value = masterclass.Bekende_Speler.P_Code;

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

                string selectQuery = @"SELECT e_code, minimale_rating, roepnaam
                                        FROM masterclass
                                        left join bekende_speler  on
                                        bekende_speler = p_code
                                        order by e_code";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int EventCode = dataReader.GetInt32("e_code");
                    int MinRating = dataReader.GetInt32("minimale_rating");
                    string BekendeSpeler = dataReader.GetString("roepnaam");
                    Masterclass masterclass = new Masterclass();

                    masterclass.E_code = EventCode;
                    masterclass.Bekende_Speler.Roepnaam = BekendeSpeler;
                    masterclass.Minimale_rating = MinRating;
                    EventController events = new EventController();
                    LocatieController locaties = new LocatieController();
                    foreach (Event val in events.GetEvents())
                    {
                        if(EventCode == val.E_code)
                        {
                            masterclass.Datum = val.Datum;
                            masterclass.L_code = val.L_code;
                            break;
                        }
                    }
                    foreach (Locatie val in locaties.GetLocaties())
                    {
                        if (masterclass.L_code == val.L_code)
                        {
                            masterclass.Locatie.Adres = val.Adres;
                        }
                    }
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

        public void Updatemasterclass(Masterclass masterclass)
        {
            try
            {
                conn.Open();
                string insertString = @"UPDATE masterclass SET minimale_rating =  @minimale_rating,
                                        bekende_speler = @bekende_speler where e_code = @e_code"; 

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter ECodeParam = new MySqlParameter("@e_code", MySqlDbType.Int32);
                MySqlParameter MinRatingParam = new MySqlParameter("@minimale_rating", MySqlDbType.Int32);
                MySqlParameter BekendeSpelerParam = new MySqlParameter("@bekende_speler", MySqlDbType.Int32);

                ECodeParam.Value = masterclass.E_code;
                MinRatingParam.Value = masterclass.Minimale_rating;
                BekendeSpelerParam.Value = masterclass.Bekende_Speler.P_Code;

                cmd.Parameters.Add(ECodeParam);
                cmd.Parameters.Add(MinRatingParam);
                cmd.Parameters.Add(BekendeSpelerParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Masterclass niet geupdate: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

