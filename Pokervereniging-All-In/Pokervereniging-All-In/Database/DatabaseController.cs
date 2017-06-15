using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokervereniging_All_In.Database
{
    public abstract class DatabaseController
    {
        protected MySqlConnection conn;

        public DatabaseController()
        {
            try
            {
                #region
                conn = new MySqlConnection("Server=localhost;Database=poker;Uid=root;Pwd=ruky125f");
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to the database.");
                Console.WriteLine(e);
                throw e;
            }
        }
        
    }
}
