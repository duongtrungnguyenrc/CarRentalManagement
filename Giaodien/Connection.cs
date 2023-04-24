using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public static class Connection
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "DESKTOP-CBHB9E2";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "CarRental";
                builder.UserID = "DESKTOP-CBHB9E2\\Nguyen";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }
}
