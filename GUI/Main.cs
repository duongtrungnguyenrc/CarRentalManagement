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
    public partial class Main : Form
    {   
        public Main(string role)
        {
            InitializeComponent();
            if(!String.Equals(role, "admin", StringComparison.OrdinalIgnoreCase)) { 
                nav_staffs.Enabled = false;
            }
        }

        private void nav_cars_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerCars form = new ManagerCars();
            form.ShowDialog();
        }

        private void nav_staffs_Click(object sender, EventArgs e)
        {
            ManagerStaffs form = new ManagerStaffs();
            form.ShowDialog();
        }

        private void nav_return_Click(object sender, EventArgs e)
        {

        }
    }
}
