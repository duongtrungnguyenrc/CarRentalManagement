using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Car
    {
        public string id { get; set; }
        public string name { get; set; }
        public byte[] imgData { get; set; }
        public double price { get; set; }
        public DateTime year { get; set; }
        public double numberOfKm { get; set; }
        public double renByTime { get; set; }
        public double rentByDate { get; set; }
        public double depositPrice { get; set; }
        public string engineType { get; set; }
        public int numberOfSeats { get; set; }

        public string status { get; set; }
        public Car(string id, string name, byte[] imgData, double price, DateTime year, double numberOfKm, double renByTime, double rentByDate, double depositPrice, string engineType, int numberOfSeats, string status)
        {
            this.id = id;
            this.name = name;
            this.imgData = imgData;
            this.price = price;
            this.year = year;
            this.numberOfKm = numberOfKm;
            this.renByTime = renByTime;
            this.rentByDate = rentByDate;
            this.depositPrice = depositPrice;
            this.engineType = engineType;
            this.numberOfSeats = numberOfSeats;
            this.status = status;
        }
        public Car(string id)
        {
            this.id = id;
        }
    }
}
