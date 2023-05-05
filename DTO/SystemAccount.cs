using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SystemAccount
    {
        public string id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string userId { get; set; }
        public SystemAccount() { }
        public SystemAccount(string id, string userName, string password, string role, string userId)
        {
            this.id = id;
            this.userName = userName;
            this.password= password;
            this.role = role;
            this.userId = userId;
        }
    }
}
