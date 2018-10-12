using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Resturant.Model
{
    class DBConnection
    {

        public static String Connection()
        {
            return ConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;
        }


        public static MySqlConnection Connect()
        {
            MySqlConnection con = new MySqlConnection(DBConnection.Connection());
            return con;
        }

    }
}