using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Authentication
    {
        public static Respond LoginAuth(string userName, string password)
        {
            SecurityUtils obj = new SecurityUtils();
            string query = "SELECT SystemAccount.password, SystemAccount.role, SystemUser.name, SystemUser.user_id " +
                "FROM SystemAccount JOIN SystemUser ON SystemAccount.user_id = SystemUser.user_id " +
                "WHERE SystemAccount.user_name = @user_name";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_name", userName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string realPassword = reader.GetString(0);
                    string role = reader.GetString(1);
                    string name = reader.GetString(2);
                    string id = reader.GetGuid(3).ToString();
                    List<string> res = new List<string>();
                    res.Add(role);
                    res.Add(id);
                    res.Add(name);
                    if (realPassword == password) // temporary
                    {
                        return new Respond(true, res, "Login Successfully!");
                    }
                }
                reader.Close();
            }
            return new Respond(false, null, "Login fail!");
        }

        public static Respond AuthenticationById(string userId, string password)
        {
            string query = "SELECT password FROM SystemAccount WHERE user_id=@user_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", userId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string realPassword = reader.GetString(0);
                    if (realPassword == password)
                    {
                        return new Respond(true, "", "Correct password!");
                    }
                    else
                    {
                        return new Respond(false, null, "Password is incorrect!");
                    }
                    reader.Close();
                }
                catch
                {
                    return new Respond(false, null, "Failed to authentication!");
                }
            }
        }
    }
}
