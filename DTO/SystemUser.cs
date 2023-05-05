using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SystemUser
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime birth { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string identifier { get; set; }
        public string shift { get; set; }
        public double coefficientsSalary { get; set; }
        public SystemUser() { }

        public SystemUser(string id, string name, DateTime birth, string gender, string phone, string address, string identifier, string shift, double coefficientsSalary)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.identifier = identifier;
            this.shift = shift;
            this.coefficientsSalary = coefficientsSalary;
        }
    }
}
