using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace BLL
{
    public static class CustomerModel
    {
        public static Respond CreateNewCustomer(Customer customer)
        {
            string query = "INSERT INTO Customer (name, birth, gender, phone, address, identifier, driver_id) OUTPUT INSERTED.customer_id VALUES (@name, @birth, @gender, @phone, @address, @identifier, @driver_id);";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@name", customer.name);
                command.Parameters.AddWithValue("@birth", customer.birth);
                command.Parameters.AddWithValue("@gender", customer.gender);
                command.Parameters.AddWithValue("@phone", customer.phone);
                command.Parameters.AddWithValue("@address", customer.address);
                command.Parameters.AddWithValue("@identifier", customer.identifier);
                command.Parameters.AddWithValue("@driver_id", customer.driverId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string newCustomerId = reader.GetGuid(0).ToString();
                    reader.Close();
                    return new Respond(true, newCustomerId, "Success");
                }
                else
                {
                    reader.Close();
                    return new Respond(false, null, "Failed to retrieve new customer ID");
                }
            }
        }
        public static Respond getCusomerById(string id)
        {
            string query = "SELECT customer_id, name, birth, phone, gender, address, identifier, driver_id FROM Customer WHERE customer_id=@id";

            using(SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Customer customer = new Customer(reader.GetGuid(0).ToString(), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3)
                        , reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                        return new Respond(true, customer, "");
                    }
                    else
                    {
                        return new Respond(false, null, "Can't get customer!");
                    }

                }
                catch(Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }
            }
        }
    }
}
