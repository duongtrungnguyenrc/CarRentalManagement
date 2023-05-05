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
    public class Authentication
    {
        private string username { get; set; }
        private string password { get; set; }

        private SqlConnection connection { get; set; }
        public Authentication() { }
        public Authentication(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.connection = Connection.GetConnection();
        }
        public Respond LoginAuth()
        {
            SecurityUtils obj = new SecurityUtils();
            string query = "SELECT SystemAccount.password, SystemAccount.role, SystemUser.name, SystemUser.user_id " +
                "FROM SystemAccount JOIN SystemUser ON SystemAccount.user_id = SystemUser.user_id " +
                "WHERE SystemAccount.user_name = @user_name";

            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@user_name", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string password = reader.GetString(0);
                    string role = reader.GetString(1);
                    string name = reader.GetString(2);
                    string id = reader.GetGuid(3).ToString();
                    List<string> res = new List<string>();
                    res.Add(role);
                    res.Add(id);
                    res.Add(name);
                    if (password == this.password) // temporary
                    {
                        return new Respond(true, res, "Login Successfully!");
                    }
                }
                reader.Close();
            }
            return new Respond(false, null, "Login fail!");
        }
    }
}
