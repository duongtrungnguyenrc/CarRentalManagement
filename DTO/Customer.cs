using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime birth { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string identifier { get; set; }
        public string driverId { get; set; }

        public Customer(string id, string name, DateTime birth,string phone, string gender, string address, string identifier, string driverId)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.phone = phone;
            this.gender = gender;
            this.address = address;
            this.identifier = identifier;
            this.driverId = driverId;
        }

        public Customer(string id) {
            this.id = id;
        }
    }
}
