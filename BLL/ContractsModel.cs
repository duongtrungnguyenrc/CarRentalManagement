using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
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
            string query = "SELECT contract_id, user_id, customer_id, car_id, rental_start_date, rental_end_date, rental_start_time, rental_end_time, contract_date," +
                "total_prices, payment_method, status  FROM PreContract";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DTO.Contract contract = new DTO.Contract(reader.GetGuid(0).ToString(), reader.GetGuid(1).ToString(), new Customer(reader.GetGuid(2).ToString()),
                            new Car(reader.GetGuid(3).ToString()), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetTimeSpan(6), reader.GetTimeSpan(7), reader.GetDateTime(8),
                            reader.GetDouble(9), reader.GetString(10), reader.GetString(11));
                        contracts.Add(contract);
                    }
                    return new Respond(true, contracts, "Successfully to get all contracts");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }
            }
        }

        public static Respond UpdateContractStatus(string contractId, string status)
        {
            string query = "UPDATE PreContract SET status=@status WHERE contract_id=@contract_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@contract_id", contractId);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return new Respond(true, "", "Successfully to update contract status!");
                    }
                    return new Respond(false, "", "Failed to update contract status!");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }
            }
        }

        public static Respond CreateContract(DTO.Contract contract)
        {
            string query = "INSERT INTO PreContract(user_id, customer_id, car_id, contract_date, rental_start_date, rental_start_time, rental_end_date, rental_end_time, total_prices, payment_method, status) " +
                "VALUES(TRY_CONVERT(uniqueidentifier, @user_id), TRY_CONVERT(uniqueidentifier, @customer_id), TRY_CONVERT(uniqueidentifier, @car_id), @contract_date, @rental_start_date, @rental_start_time, @rental_end_date, @rental_end_time, @total_prices, @payment_method, @status)";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", contract.userId);
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

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        CarsModel.UpdateCarStatus(contract.car.id, "Renting");
                        return new Respond(true, "", "Successfully !");
                    }
                    return new Respond(false, "", "Failed!");
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }
            }
        }

        public static Respond CreatePostContract(PostContracts postContracts)
        {
            string query = "INSERT INTO PostContract(user_id, contract_id, status, note, extra_charge, payment_method) " +
                "VALUES(@user_id, @contract_id, @status, @note, @extra_charge, @payment_method)";

            using(SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", postContracts.accountId);
                command.Parameters.AddWithValue("@contract_id", postContracts.contractId);
                command.Parameters.AddWithValue("@status", postContracts.status);
                command.Parameters.AddWithValue("@note", postContracts.note);
                command.Parameters.AddWithValue("@extra_charge", postContracts.extraCharge);
                command.Parameters.AddWithValue("payment_method", postContracts.paymentMethod);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return new Respond(true, null, "Successfully to create post contract!");
                    }
                    return new Respond(false, null, "Failed to create post contract!");
                }
                catch(Exception ex)
                {
                    return new Respond(false, null, ex.ToString());

                }
            }
        }

        public static Respond GetPostContractById(string contractId)
        {
            string query = "SELECT post_contract_id, user_id, contract_id, status, note, extra_charge, payment_method " +
                "FROM PostContract WHERE contract_id=@contract_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@contract_id", contractId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        PostContracts contract = new PostContracts(reader.GetGuid(0).ToString(), reader.GetGuid(1).ToString(),
                            reader.GetGuid(2).ToString(), reader.GetString(3), reader.GetString(4), reader.GetDouble(5), reader.GetString(6));
                        return new Respond(true, contract, "Successfully to get post contract");
                    }
                    else
                    {
                        return new Respond(false, null, "Contract with id does not exists");
                    }
                }
                catch(SqlException ex)
                {
                    return new Respond(false, ex, ex.ToString());
                }
            }
        }

        public static Respond GetContractByUser(string userId)
        {
            List<DTO.Contract> contracts = new List<DTO.Contract>();
            string query = "SELECT contract_id, user_id, customer_id, car_id, rental_start_date, rental_end_date, rental_start_time, rental_end_time, contract_date, " +
                "total_prices, payment_method, status FROM PreContract WHERE user_id=@user_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@user_id", userId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DTO.Contract contract = new DTO.Contract(reader.GetGuid(0).ToString(), reader.GetGuid(1).ToString(), new Customer(reader.GetGuid(2).ToString()),
                                new Car(reader.GetGuid(3).ToString()), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetTimeSpan(6), reader.GetTimeSpan(7), reader.GetDateTime(8),
                                reader.GetDouble(9), reader.GetString(10), reader.GetString(11));

                            contracts.Add(contract);
                        }
                        return new Respond(true, contracts, "Successfully to get contract by user");
                    }
                    else
                    {
                        return new Respond(false, null, "Data is empty");
                    }
                }
                catch (Exception ex)
                {
                    return new Respond(false, null, ex.ToString());
                }
            }
        }
    }
}
