using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    public class DBConnection
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-B0D0J2Q\SQLEXPRESS;Initial Catalog=COFFEE_MANAGEMENT;Integrated Security=True";

        public DBConnection()
        {

        }

        public static string GetConnection()
        {
            return connectionString;
        }
    }
}
