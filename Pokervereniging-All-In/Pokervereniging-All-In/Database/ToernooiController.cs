﻿using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    public class ToernooiController : DatabaseController
    {
        public List<Toernooi> GetToernooien()
        {
            List<Toernooi> Toernooien = new List<Toernooi>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM toernooi";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                SpelerController SC = new SpelerController();

                while (dataReader.Read())
                {
                    int e_code = dataReader.GetInt32("e_code");
                    int mindeelnemers = dataReader.GetInt32("minimum_deelnemers");
                    int inleggeld = dataReader.GetInt32("inleggeld");
                    Speler eersteplaats = null;
                    Speler tweedeplaats = null;
                    Speler derdeplaats = null;
                    if (dataReader["eerste_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("eerste_plaats"));
                    if (dataReader["tweede_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("tweede_plaats"));
                    if (dataReader["derde_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("derde_plaats"));

                    Toernooi toernooi = new Toernooi(e_code, mindeelnemers, inleggeld, eersteplaats, tweedeplaats, derdeplaats);
                    Toernooien.Add(toernooi);
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

            return Toernooien;
        }

        public Toernooi GetToernooi(int ecode)
        {
            Toernooi toernooi = null;

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM toernooi WHERE e_code = @ecode";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                SpelerController SC = new SpelerController();

                MySqlParameter ecodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                ecodeParam.Value = ecode;

                cmd.Parameters.Add(ecodeParam);
                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int e_code = dataReader.GetInt32("e_code");
                    int mindeelnemers = dataReader.GetInt32("minimum_deelnemers");
                    int inleggeld = dataReader.GetInt32("inleggeld");
                    Speler eersteplaats = null;
                    Speler tweedeplaats = null;
                    Speler derdeplaats = null;
                    if (dataReader["eerste_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("eerste_plaats"));
                    if (dataReader["tweede_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("tweede_plaats"));
                    if (dataReader["derde_plaats"] != DBNull.Value)
                        eersteplaats = SC.GetSpeler(dataReader.GetInt32("derde_plaats"));


                    toernooi = new Toernooi(e_code, mindeelnemers, inleggeld, eersteplaats, tweedeplaats, derdeplaats);
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

            return toernooi;
        }

        public void InsertToernooi(Toernooi toernooi)
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO toernooi (e_code, minimum_deelnemers, inleggeld) 
                                        VALUES (@ecode, @minimum_deelnemers, @inleggeld)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                MySqlParameter MinimumDeelnemersParam = new MySqlParameter("@minimum_deelnemers", MySqlDbType.Int32);
                MySqlParameter InleggeldParam = new MySqlParameter("@inleggeld", MySqlDbType.Int32);

                EcodeParam.Value = toernooi.E_code;
                MinimumDeelnemersParam.Value = toernooi.Mindeelnemers;
                InleggeldParam.Value = toernooi.Inleggeld;

                cmd.Parameters.Add(EcodeParam);
                cmd.Parameters.Add(MinimumDeelnemersParam);
                cmd.Parameters.Add(InleggeldParam);

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

        public void SetWinners(int ecode, Speler eerste, Speler tweede, Speler derde)
        {
            try
            {
                conn.Open();
                string insertString = @"UPDATE toernooi
                                        SET eerste_plaats = @eerste, tweede_plaats = @tweede, derde_plaats = @derde
                                        WHERE e_code = @ecode";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                MySqlParameter EersteParam = new MySqlParameter("@eerste", MySqlDbType.Int32);
                MySqlParameter TweedeParam = new MySqlParameter("@tweede", MySqlDbType.Int32);
                MySqlParameter DerdeParam = new MySqlParameter("@derde", MySqlDbType.Int32);

                EcodeParam.Value = ecode;
                EersteParam.Value = eerste.P_Code;
                TweedeParam.Value = tweede.P_Code;
                DerdeParam.Value = derde.P_Code;

                cmd.Parameters.Add(EcodeParam);
                cmd.Parameters.Add(EersteParam);
                cmd.Parameters.Add(TweedeParam);
                cmd.Parameters.Add(DerdeParam);

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

        public void ChangeToernooi(Toernooi t, Event e)
        {
            try
            {
                conn.Open();
                string updateStringToernooi = "UPDATE toernooi SET minimum_deelnemers = @mindeelnemers, inleggeld = @inleggeld WHERE e_code = @ecode"; 
                string updateStringEvent = "UPDATE event SET datum = @datum, l_code = @lcode WHERE e_code = @ecode";

                MySqlCommand cmdToernooi = new MySqlCommand(updateStringToernooi, conn);
                MySqlCommand cmdEvent = new MySqlCommand(updateStringEvent, conn);

                MySqlParameter EcodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                MySqlParameter mindeelnemersParam = new MySqlParameter("@mindeelnemers", MySqlDbType.Int32);
                MySqlParameter inleggeldParam = new MySqlParameter("@inleggeld", MySqlDbType.Int32);
                MySqlParameter datumParam = new MySqlParameter("@datum", MySqlDbType.Date);
                MySqlParameter lcodeParam = new MySqlParameter("@lcode", MySqlDbType.Int32);

                EcodeParam.Value = t.E_code;
                mindeelnemersParam.Value = t.Mindeelnemers;
                inleggeldParam.Value = t.Inleggeld;
                datumParam.Value = e.Datum;
                lcodeParam.Value = e.L_code;

                cmdToernooi.Parameters.Add(EcodeParam);
                cmdToernooi.Parameters.Add(mindeelnemersParam);
                cmdToernooi.Parameters.Add(inleggeldParam);
                cmdEvent.Parameters.Add(datumParam);
                cmdEvent.Parameters.Add(lcodeParam);
                cmdEvent.Parameters.Add(EcodeParam);

                cmdEvent.Prepare();
                cmdToernooi.Prepare();

                cmdEvent.ExecuteNonQuery();
                cmdToernooi.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
