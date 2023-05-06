using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
                    (double)row["deposit_price"], row["engine_type"].ToString(), (int)row["number_of_seats"]));

                }
            }

            return cars;
        }

        public static Respond InserCar(Car car)
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
                    return new Respond(true, "", "Success!");
                }
                else
                {
                    return new Respond(false, "", "Failed!");
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
    }
}
