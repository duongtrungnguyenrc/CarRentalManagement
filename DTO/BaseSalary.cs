using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaseSalary
    {
        public string id { get; set; }
        public double baseSalary { get; set; }
        public DateTime updateDate { get; set; }
        public BaseSalary(string id, double baseSalary, DateTime updateDate)
        {
            this.id = id;
            this.baseSalary = baseSalary;
            this.updateDate = updateDate;
        }
    }
}
