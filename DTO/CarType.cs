using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CarType
    {
        public string typeId { get; set; }
        public int numberOfSeats { get; set; }
        public CarType(string typeId,  int numberOfSeats) {
            this.typeId = typeId;
            this.numberOfSeats = numberOfSeats;
        }
    }
}
