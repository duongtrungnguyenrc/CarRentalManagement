using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class UserModel
    {

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        private SqlConnection connection;
        public UserModel() {
            this.connection = Connection.GetConnection();
        }

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

        public Respond getUserById(string id)
        {
            string query = "SELECT user_id, name, birth, gender, phone, address, identifier, shift, coefficients_salary FROM SystemUser WHERE user_id=@user_id";
            using(SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@user_id", id);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    SystemUser user =  new SystemUser(reader.GetGuid(0).ToString(), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), 
                        reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetDouble(8));
                    return new Respond(true, user, "Successfully to get user");
                }
                catch(Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }

            }
        }

        public Respond getAccountById(string id)
        {
            string query = "SELECT account_id, user_name, password, role, user_id FROM SystemAccount WHERE user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@user_id", id);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    SystemAccount account = new SystemAccount(reader.GetGuid(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetGuid(4).ToString());
                    return new Respond(true, account, "Successfully to get account!");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }

            }
        }

        public Respond updateAccount(SystemAccount account)
        {
            string query = "UPDATE SystemAccount SET user_name=@user_name, password=@password" +
                " WHERE user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@user_name", account.userName);
                command.Parameters.AddWithValue("@password", account.password);
                command.Parameters.AddWithValue("@user_id", account.userId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return new Respond(true, "", "Successfully to update account!");
                    }
                    else
                    {
                        return new Respond(false, "", "Failed to update account!");
                    }
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }

            }
        }

        public Respond UpdateUser(SystemUser user)
        {
            string query = "UPDATE SystemUser set name=@name, gender=@gender, birth=@birth, address=@address, identifier=@identifier, shift=@shift, coefficients_salary=@coefficients_salary " +
                "where user_id=@id";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@id", user.id);
                command.Parameters.AddWithValue("@name", user.name);
                command.Parameters.AddWithValue("@birth", user.birth);
                command.Parameters.AddWithValue("@gender", user.gender);
                command.Parameters.AddWithValue("@phone", user.phone);
                command.Parameters.AddWithValue("@address", user.address);
                command.Parameters.AddWithValue("@identifier", user.identifier);
                command.Parameters.AddWithValue("@shift", user.shift);
                command.Parameters.AddWithValue("@coefficients_salary", user.coefficientsSalary);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return new Respond(true, "", "Successfully to update informations!");
                }
                else
                {
                    return new Respond(false, "", "Failed to update information!");
                }
            }
        }

        public Respond getBaseSalary()
        {
            string query = "SELECT TOP 1 * FROM Salary ORDER BY update_time DESC";

            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    BaseSalary baseSalary = new BaseSalary(reader.GetGuid(0).ToString(), reader.GetDouble(1), reader.GetDateTime(2));
                    return new Respond(true, baseSalary, "Successfully to get base salary");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }

            }
        }
    }
}
