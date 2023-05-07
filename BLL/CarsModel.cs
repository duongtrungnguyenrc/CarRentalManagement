using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Runtime.ConstrainedExecution;

namespace BLL
{
    public static class CarsModel
    {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            string query = "SELECT * FROM Car";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.GetConnection()))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    cars.Add(new Car(row["car_id"].ToString(), row["car_name"].ToString(), (byte[])row["car_img"], (double)row["car_price"],
                    Convert.ToDateTime(row["car_year"]), (double)row["number_of_km"], (double)row["rent_by_time"], (double)row["rent_by_date"],
                    (double)row["deposit_price"], row["engine_type"].ToString(), (int)row["number_of_seats"], row["status"].ToString()));

                }
            }

            return cars;
        }

        public static Respond GetCarById(string carId)
        {
            string query = "SELECT car_id, car_name, car_img, car_price, car_year, number_of_km, rent_by_time, rent_by_date, deposit_price, " +
                "engine_type, number_of_seats, status FROM Car " +
                "WHERE car_id=@car_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@car_id", carId);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        Car car = new Car(reader.GetGuid(0).ToString(), reader.GetString(1), (byte[])reader[2], reader.GetDouble(3) ,reader.GetDateTime(4), reader.GetDouble(5), 
                            reader.GetDouble(6), reader.GetDouble(7), reader.GetDouble(8), reader.GetString(9), reader.GetInt32(10), reader.GetString(11));
                        return new Respond(true, car, "Successfully to get car!");
                    }
                    else
                    {
                        return new Respond(false, null, "Failed to get car!");
                    }
                }
                catch(Exception ex)
                {
                    return new Respond(false, null, ex.ToString());

                }
            }
        }

        public static Respond AddNewCar(Car car)
        {
            string query = "INSERT INTO Car (car_name, car_img, engine_type, number_of_seats,car_price, car_year, number_of_km,rent_by_time, rent_by_date, deposit_price)" +
                           "VALUES (@car_name, @img_src, @engine_type, @number_of_seats, @car_price, @car_year, @number_of_km, @rent_by_time, @rent_by_date, @deposit_price); ";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@car_name", car.name);
                command.Parameters.AddWithValue("@img_src", car.imgData);
                command.Parameters.AddWithValue("@engine_type", car.engineType);
                command.Parameters.AddWithValue("@number_of_seats", car.numberOfSeats);
                command.Parameters.AddWithValue("@car_price", car.price);
                command.Parameters.AddWithValue("@car_year", car.year);
                command.Parameters.AddWithValue("@number_of_km", car.numberOfKm);
                command.Parameters.AddWithValue("@rent_by_time", car.renByTime);
                command.Parameters.AddWithValue("@rent_by_date", car.rentByDate);
                command.Parameters.AddWithValue("@deposit_price", car.depositPrice);
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

        public static Respond UpdateCar(Car car)
        {
            string query = "UPDATE Car SET car_name=@car_name, number_of_seats=@number_of_seats, car_img=@car_img, engine_type=@engine_type, car_price=@car_price, car_year=@car_year," +
                " rent_by_time=@rent_by_time, rent_by_date=@rent_by_date, deposit_price=@deposit_price where car_id = @car_id";

            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@car_name", car.name);
                command.Parameters.AddWithValue("@car_img", car.imgData);
                command.Parameters.AddWithValue("@engine_type", car.engineType);
                command.Parameters.AddWithValue("@number_of_seats", car.numberOfSeats);
                command.Parameters.AddWithValue("@car_price", car.price);
                command.Parameters.AddWithValue("@car_year", car.year);
                command.Parameters.AddWithValue("@number_of_km", car.numberOfKm);
                command.Parameters.AddWithValue("@rent_by_time", car.renByTime);
                command.Parameters.AddWithValue("@rent_by_date", car.rentByDate);
                command.Parameters.AddWithValue("@deposit_price", car.depositPrice);
                command.Parameters.AddWithValue("@car_id", car.id);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return new Respond(true, "", $"Successfully to update {car.name}!");
                }
                else
                {
                    return new Respond(false, "", $"Failed to update {car.name}!");
                }
            }
        }

        public static Respond UpdateCarStatus(string carId, string status)
        {
            string query = "UPDATE Car SET status=@status WHERE car_id=@car_id";

            using(SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@car_id", carId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return new Respond(true, "", "Successfully to update status!");
                }
                else
                {
                    return new Respond(false, "", "Failed to update status!");
                }
            }
        }

        public static Respond DeleteCar(string deleteId)
        {
            string query = "DELETE FROM Car WHERE car_id=@car_id";
            using (SqlCommand command = new SqlCommand(query, Connection.GetConnection()))
            {
                command.Parameters.AddWithValue("@car_id", deleteId);
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

        public static Respond SearchCar(string carType, string engineType)
        {
            string query = "SLECT car_id, car_name, car_img, car_price, car_year, number_of_km, rent_by_time, rent_by_date, deposit_price, engine_type, number_of_seats, status WHERE ";
            List<bool> exists = new List<bool> { false, false };
            if (!String.IsNullOrEmpty(carType))
            {
                query += "number_of_seats=@number_of_seats ";
                exists[0] = true;
            }
            if (!String.IsNullOrEmpty(engineType))
            {
                query += "engine_type=@engine_type";
                exists[1] = true;
            }
            List<Car> cars = new List<Car>(); 
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.GetConnection()))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    cars.Add(new Car(row["car_id"].ToString(), row["car_name"].ToString(), (byte[])row["car_img"], (double)row["car_price"],
                    Convert.ToDateTime(row["car_year"]), (double)row["number_of_km"], (double)row["rent_by_time"], (double)row["rent_by_date"],
                    (double)row["deposit_price"], row["engine_type"].ToString(), (int)row["number_of_seats"], row["status"].ToString()));

                }
            }
            return new Respond(true, cars, "Successfully to get Cars");


        }
    }
}
