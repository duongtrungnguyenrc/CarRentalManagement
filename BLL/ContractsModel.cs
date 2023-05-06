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
   public static class ContractsModel
    {
        public static Respond GetAllContracts()
        {
            List<DTO.Contract> contracts = new List<DTO.Contract>();
            string query = "SELECT * FROM PreContract";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string id = reader.GetGuid(0).ToString();
                        DateTime startDate = reader.GetDateTime(1);
                        DateTime endDate = reader.GetDateTime(2);
                        DateTime createDate = reader.GetDateTime(3);
                        double totalPrices = reader.GetDouble(4);
                        string paymentMethod = reader.GetString(5);
                        string status = reader.GetString(6);
                        Customer customer = new Customer(reader.GetGuid(7).ToString());
                        TimeSpan startTime = reader.GetTimeSpan(8);
                        TimeSpan endTime = reader.GetTimeSpan(9);
                        Car car = new Car(reader.GetGuid(10).ToString());
                        string staffId = reader.GetGuid(11).ToString();
                        DTO.Contract contract = new DTO.Contract(id, staffId, customer, car, startDate, endDate, startTime, endTime, createDate, totalPrices, paymentMethod, status);
                        contracts.Add(contract);
                    }
                    return new Respond(true, contracts, "Success");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }

            }
        }

        public static Respond CreateContract(Contract contract)
        {
            string query = "INSERT INTO PreContract(user_id, customer_id, car_id, contract_date, rental_start_date, rental_start_time, rental_end_date, rental_end_time, total_prices, payment_method, status) " +
                "VALUES(TRY_CONVERT(uniqueidentifier, @user_id), TRY_CONVERT(uniqueidentifier, @customer_id), TRY_CONVERT(uniqueidentifier, @car_id), @contract_date, @rental_start_date, @rental_start_time, @rental_end_date, @rental_end_time, @total_prices, @payment_method, @status)";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", contract.staffId);
                command.Parameters.AddWithValue("@customer_id", contract.customer.id);
                command.Parameters.AddWithValue("@car_id", contract.car.id);
                command.Parameters.AddWithValue("contract_date", DateTime.Today);
                command.Parameters.AddWithValue("@rental_start_date", contract.startDate.Date);
                command.Parameters.AddWithValue("@rental_start_time", contract.startTime);
                command.Parameters.AddWithValue("@rental_end_date", contract.endDate.Date);
                command.Parameters.AddWithValue("@rental_end_time", contract.endTime);
                command.Parameters.AddWithValue("@total_prices", contract.totalPrices);
                command.Parameters.AddWithValue("@payment_method", contract.paymentMethod);
                command.Parameters.AddWithValue("@status", contract.status);
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
    }
}
