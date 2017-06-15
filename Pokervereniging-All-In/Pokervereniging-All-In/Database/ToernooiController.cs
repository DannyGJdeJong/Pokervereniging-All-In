﻿using MySql.Data.MySqlClient;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokervereniging_All_In.Database
{
    class ToernooiController : DatabaseController
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
                    Speler eersteplaats = SC.GetSpeler(dataReader.GetInt32("eerste_plaats"));
                    Speler tweedeplaats = SC.GetSpeler(dataReader.GetInt32("tweede_plaats"));
                    Speler derdeplaats = SC.GetSpeler(dataReader.GetInt32("derde_plaats"));

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
                MySqlDataReader dataReader = cmd.ExecuteReader();
                SpelerController SC = new SpelerController();

                MySqlParameter ecodeParam = new MySqlParameter("@ecode", MySqlDbType.Int32);
                ecodeParam.Value = ecode;

                cmd.Parameters.Add(ecodeParam);
                cmd.Prepare();

                while (dataReader.Read())
                {
                    int e_code = dataReader.GetInt32("e_code");
                    int mindeelnemers = dataReader.GetInt32("minimum_deelnemers");
                    int inleggeld = dataReader.GetInt32("inleggeld");
                    Speler eersteplaats = SC.GetSpeler(dataReader.GetInt32("eerste_plaats"));
                    Speler tweedeplaats = SC.GetSpeler(dataReader.GetInt32("tweede_plaats"));
                    Speler derdeplaats = SC.GetSpeler(dataReader.GetInt32("derde_plaats"));

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
    }
}
