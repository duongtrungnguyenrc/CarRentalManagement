using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public static class UserModel
    {
        public static List<SystemUser> GetUsers()
        {
            List<SystemUser> staffs = new List<SystemUser>();
            string query = "SELECT * FROM SystemUser";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.GetConnection()))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    staffs.Add(new SystemUser(row["user_id"].ToString(), row["name"].ToString(), Convert.ToDateTime(row["birth"]), row["gender"].ToString(), row["phone"].ToString(),
                        row["address"].ToString(), row["identifier"].ToString(), row["shift"].ToString(), (double)row["coefficients_salary"]));
                }
            }

            return staffs;
        }

        public static Respond CreateUser(SystemUser user)
        {
            string query = "INSERT INTO SystemUser (name, birth, gender, phone, address, identifier, shift, coefficients_salary) " +
                           "VALUES (@name, @birth, @gender, @phone, @address, @identifier, @shift, @coefficients_salary); ";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
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
                    return new Respond(true, "", "Success!");
                }
                else
                {
                    return new Respond(false, "", "Failed!");
                }
            }
        }

        public static Respond DeleteUser(string deleteId)
        {
            string query = "delete from SystemUser where user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", deleteId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return new Respond(true, "", "Delete Success!");
                }
                else
                {
                    return new Respond(false, "", "Delete Failed!");
                }
            }
        }

        public static Respond UpdateUser(SystemUser user)
        {
            string query = "UPDATE SystemUser set name=@name, gender=@gender, birth=@birth, address=@address, identifier=@identifier, shift=@shift, coefficients_salary=@coefficients_salary " +
                "where user_id=@id";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
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
                    return new Respond(true, "", "Delete Success!");
                }
                else
                {
                    return new Respond(false, "", "Delete Failed!");
                }
            }
        }
        public static Respond getUserById(string id)
        {
            string query = "SELECT user_id, name, birth, gender, phone, address, identifier, shift, coefficients_salary FROM SystemUser WHERE user_id=@user_id";
            using(SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
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

        public static Respond getAccountById(string id)
        {
            string query = "SELECT account_id, user_name, password, role, user_id FROM SystemAccount WHERE user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
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

        public static Respond updateAccount(SystemAccount account)
        {
            string query = "UPDATE SystemAccount SET user_name=@user_name, password=@password" +
                " WHERE user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
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

        public static Respond getBaseSalary()
        {
            string query = "SELECT TOP 1 * FROM Salary ORDER BY update_time DESC";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
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
