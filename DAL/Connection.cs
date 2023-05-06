using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public static class Connection
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "171.244.61.127";
                builder["Integrated Security"] = false; // Chuyển sang xác thực SQL Server
                builder["User ID"] = "sa"; // Tên người dùng
                builder["Password"] = "Nguyen292003."; // Mật khẩu
                builder["Initial Catalog"] = "CarRental";
                builder["MultipleActiveResultSets"] = true;
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }


}
