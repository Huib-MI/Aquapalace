using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapalaca
{
    internal class Databases
    {
        public static MySqlConnection start()
        {
            //basisgegevens toegang database
            string dbServername = "127.0.0.1";
            string dbUsername = "root";
            string dbPassword = "";
            string dbDatabase = "aquapalace";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = dbServername;
            builder.UserID = dbUsername;
            builder.Password = dbPassword;
            builder.Database = dbDatabase;

            //verbinding
            MySqlConnection Connection = new MySqlConnection(builder.ToString());
            return Connection;
        }
    }
}
