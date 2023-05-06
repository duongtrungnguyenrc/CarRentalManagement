using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PostContracts
    {
        public string postContractId { get; set; }
        public string accountId { get; set; }
        public string contractId { get; set; }
        public string status { get; set; }
        public string note { get; set; }
        public double extraCharge { get; set; }

        public string paymentMethod { get; set; }

        public PostContracts(string postContractId, string accountId, string contractId, string status, string note, double extraCharge, string paymentMethod)
        {
            this.postContractId = postContractId;
            this.accountId = accountId;
            this.contractId = contractId;
            this.status = status;
            this.note = note;
            this.extraCharge = extraCharge;
            this.paymentMethod = paymentMethod;
        }
    }
}
