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
            string query = "SELECT password, role FROM SystemAccount WHERE user_name = @userName";

            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@userName", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string password = reader.GetString(0);
                    string role = reader.GetString(1);

                    if (password == this.password) // temporary
                    {
                        return new Respond(true, role, "Login Successfully!");
                    }
                }
                reader.Close();
            }
            return new Respond(false, null, "Login fail!");
        }
    }
}
