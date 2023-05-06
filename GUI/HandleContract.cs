using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HandleContract : Form
    {
        private string userID;
        private Contract contract;
        public HandleContract(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public HandleContract(string userID, Contract contract) : this(userID)
        {
            this.contract = contract;
        }

        private void HandleContract_Load(object sender, EventArgs e)
        {

        }
    }
}
