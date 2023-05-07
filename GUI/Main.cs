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
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            if (!String.Equals(role, "admin", StringComparison.OrdinalIgnoreCase)) { 
                nav_staffs.Enabled = false;
                nav_cars.Enabled = false;
                nav_ManageContracts.Enabled = false;
            }
            this.userID = id;
            this.role = role;
            lb_name.Text = "User: " + name;
            lb_role.Text = "Role: " + role;
        }

        private void nav_cars_Click(object sender, EventArgs e)
        {
            ManagerCars form = new ManagerCars();
            this.Hide();
            form.ShowDialog(this);
        }

        private void nav_staffs_Click(object sender, EventArgs e)
        {
            ManagerStaffs form = new ManagerStaffs();
            this.Hide();
            form.ShowDialog(this);
        }
        private void nav_ManageContracts_Click(object sender, EventArgs e)
        {
            ManageContracts form = new ManageContracts(this.userID);
            this.Hide();
            form.ShowDialog(this);
        }

        private void nav_setting_Click(object sender, EventArgs e)
        {
            SettingConfirm form = new SettingConfirm(this.userID, this.role);
            this.Hide();
            form.ShowDialog(this);
        }

        private void nav_new_contract_Click(object sender, EventArgs e)
        {
            CreateContract form = new CreateContract(this.userID);
            form.ShowDialog();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            if(this.Owner!= null)
            {
                this.Owner.Show();
                this.Hide();
            }
        }
    }
}
