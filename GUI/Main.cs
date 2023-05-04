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
        public Main(string role, string name)
        {
            InitializeComponent();
            if(!String.Equals(role, "admin", StringComparison.OrdinalIgnoreCase)) { 
                nav_staffs.Enabled = false;
            }
            lb_name.Text = "Hello: " + name;
            lb_role.Text = "Role: " + role;
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

        private void nav_rentals_Click(object sender, EventArgs e)
        {
            DisplayCars form = new DisplayCars();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
