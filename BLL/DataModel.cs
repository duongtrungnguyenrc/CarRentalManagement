using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

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


        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            string query = "SELECT * FROM Car";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, this.connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    cars.Add(new Car(row["car_id"].ToString(), row["car_name"].ToString(), (byte[]) row["car_img"], (double)row["car_price"],
                    Convert.ToDateTime(row["car_year"]), (double)row["number_of_km"], (double)row["rent_by_time"], (double)row["rent_by_date"], 
                    (double)row["deposit_price"], row["engine_type"].ToString(), (int)row["number_of_seats"]));

                }
            }

            return cars;
        }

        public Respond InserCar(Car car)
        {
            string query = "INSERT INTO Car (car_name, car_img, engine_type, number_of_seats,car_price, car_year, number_of_km,rent_by_time, rent_by_date, deposit_price)" +
                           "VALUES (@car_name, @img_src, @engine_type, @number_of_seats, @car_price, @car_year, @number_of_km,@rent_by_time, @rent_by_date, @deposit_price); ";

            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@car_name", car.name);
                command.Parameters.AddWithValue("@img_src", car.imgData);
                command.Parameters.AddWithValue("@engine_type", car.engineType);
                command.Parameters.AddWithValue("@number_of_seats", car.numberOfSeats);
                command.Parameters.AddWithValue("@car_price", car.price);
                command.Parameters.AddWithValue("@car_year",car.year);
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

        public Respond UpdateCar(Car car)
        {
            string query = "UPDATE Car SET car_name=@car_name, number_of_seats=@number_of_seats, car_img=@car_img, engine_type=@engine_type, car_price=@car_price, car_year=@car_year," +
                " rent_by_time=@rent_by_time, rent_by_date=@rent_by_date, deposit_price=@deposit_price where car_id = @car_id";

            using (SqlCommand command = new SqlCommand(query, this.connection))
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

        public Respond DeleteCar(string deleteId)
        {
            string query =  "DELETE FROM Car WHERE car_id=@car_id";
            using(SqlCommand command = new SqlCommand(query, this.connection))
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
