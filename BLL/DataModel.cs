using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataModel
    {
        private SqlConnection connection { get; set; }
        public DataModel() {
            this.connection = Connection.GetConnection();
        }

        public List<SystemUser> GetStaffs()
        {
            List<SystemUser> staffs = new List<SystemUser>();
            string query = "SELECT * FROM SystemUser";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, this.connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    staffs.Add(new SystemUser(row["user_id"].ToString(), row["name"].ToString(), Convert.ToDateTime(row["birth"]), row["gender"].ToString(), row["phone"].ToString(),
                        row["address"].ToString(), row["identifier"].ToString(), row["shift"].ToString(), row["coefficients_salary"].ToString()));
                }
            }

            return staffs;
        }

        public Respond InsertStaff(SystemUser user)
        {
            string query = "INSERT INTO SystemUser (name, birth, gender, phone, address, identifier, shift, coefficients_salary) " +
                           "VALUES (@name, @birth, @gender, @phone, @address, @identifier, @shift, @coefficients_salary); ";

            using (SqlCommand command = new SqlCommand(query, this.connection))
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

        public Respond DeleteStaff(string deleteId)
        {
            string query = "delete from SystemUser where user_id=@user_id";
            using (SqlCommand command = new SqlCommand(query, this.connection))
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

        public Respond UpdateStaff(SystemUser user)
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
                    return new Respond(true, "", "Delete Success!");
                }
                else
                {
                    return new Respond(false, "", "Delete Failed!");
                }
            }
        }

    }
}
