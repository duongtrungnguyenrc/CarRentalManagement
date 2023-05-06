using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Respond
    {
        private Boolean status { get; set; }
        private object data { get; set; }
        private string description { get; set; }
        public Respond(Boolean status, object data, string description)
        {
            this.status = status;
            this.data = data;
            this.description = description;
        }

        public Boolean getStatus() { return status; }
        public object getData() { return data; }
        public string getDescription() { return description; }
    }
}
