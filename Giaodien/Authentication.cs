using Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRental
{
    internal class Authentication
    {
        private string username { get; set; }
        private string password { get; set; }
        public Authentication() { }
        public Authentication(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Respond LoginAuth(SqlConnection connection)
        {
            SecurityUtils obj = new SecurityUtils();
            string query = "SELECT password, role FROM SystemAccount WHERE user_name = @userName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userName", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string password = reader.GetString(0);
                    string role = reader.GetString(1);

                    if (password == SecurityUtils.SaltedHash(this.password))
                    {
                        return new Respond(true, role, "Login Successfully!");
                    }
                }
            }
            return new Respond(false, null, "Login fail!");
        }

    }
}
