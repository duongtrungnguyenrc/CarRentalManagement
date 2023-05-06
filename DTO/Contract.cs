using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Contract
    {
        public string contractId { get; set; }

        public string userId { get; set; }
        public Customer customer { get; set; }
        public Car car { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public DateTime createDate { get; set; }
        public double totalPrices { get; set; }
        public string paymentMethod { get; set; }
        public string status { get; set; }

        public Contract(string contractId, string staffId, Customer customer, Car car, DateTime startDate, DateTime endDate, TimeSpan startTime, TimeSpan endTime, DateTime createDate, double totalPrices, string paymentMethod, string status)
        {
            this.contractId = contractId;
            this.userId = staffId;
            this.customer = customer;
            this.car = car;
            this.startDate = startDate;
            this.endDate = endDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.createDate = createDate;
            this.totalPrices = totalPrices;
            this.paymentMethod = paymentMethod;
            this.status = status;
        }
    }
}
