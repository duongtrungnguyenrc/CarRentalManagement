using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    internal class UserModel
    {

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserModel() { }

        public UserModel(string email, string firstName, string lastName, string password, string role)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Role = role;
        }

        public void InsertUser(SqlConnection connection)
        {
            string query = "INSERT INTO users (email, first_name, last_name, password, role) " +
                           "VALUES (@Email, @FirstName, @LastName, @Password, @Role)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Role", Role);

                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool CheckIfNewPasswordIsSameAsOld(SqlConnection connection)
        {
            string query = "SELECT password FROM users WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                string oldPassword = (string)command.ExecuteScalar();

                return Password == oldPassword;
            }
        }
    }
}
