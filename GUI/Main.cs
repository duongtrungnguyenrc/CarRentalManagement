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
        private string userID;
        private string role;
        public Main(string role, string id, string name)
        {
            InitializeComponent();
            if(!String.Equals(role, "admin", StringComparison.OrdinalIgnoreCase)) { 
                nav_staffs.Enabled = false;
            }
            this.userID = id;
            this.role = role;
            lb_name.Text = "User: " + name;
            lb_role.Text = "Role: " + role;
        }

        private void nav_cars_Click(object sender, EventArgs e)
        {
            ManagerCars form = new ManagerCars();
            form.ShowDialog();
        }

        private void nav_staffs_Click(object sender, EventArgs e)
        {
            ManagerStaffs form = new ManagerStaffs();
            form.ShowDialog();
        }
        private void nav_ManageContracts_Click(object sender, EventArgs e)
        {
            ManageContracts form = new ManageContracts(this.userID);
            form.ShowDialog();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nav_setting_Click(object sender, EventArgs e)
        {
            Setting form = new Setting(this.userID, this.role);
            form.ShowDialog();
        }
    }
}
