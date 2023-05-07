using BLL;
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
    public partial class Setting : Form
    {
        private string userID;

        private Boolean isAdminRole;

        private SystemUser user;
        public Setting(string userID, string role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            this.userID = userID;
            LoadUserInfo();
            LoadAccount();
            LoadSalary();
            LoadSalesInfo();
            this.isAdminRole = String.Equals(role, "admin", StringComparison.OrdinalIgnoreCase);
        }

        private void LoadUserInfo()
        {
            Respond res = UserModel.getUserById(userID);
            if (res.getStatus())
            {
                this.user = (SystemUser)res.getData();
                txt_id.Text = this.user.id;
                txt_name.Text = this.user.name;
                cb_gender.Text = this.user.gender;
                txt_phone.Text = this.user.phone;
                txt_address.Text = this.user.address;
                txt_identity.Text = this.user.identifier;
                cb_shift.Text = this.user.shift;
                txt_coefficients_salary.Text = this.user.coefficientsSalary.ToString();
                txt_birth.Value = this.user.birth;
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void LoadAccount()
        {
            Respond res = UserModel.getAccountById(txt_id.Text);
            if (res.getStatus())
            {
                SystemAccount account = (SystemAccount)res.getData();
                txt_account_id.Text = account.id;
                txt_user_name.Text = account.userName;
                txt_password.Text = account.password;
                cb_role.Text = account.role; 
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void LoadSalary()
        {
            Respond res = UserModel.GetBaseSalary();
            if (res.getStatus())
            {
                BaseSalary baseSalary = (BaseSalary)res.getData();
                txt_salary.Text = (baseSalary.baseSalary * this.user.coefficientsSalary).ToString();
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void LoadSalesInfo()
        {
            Respond res = ContractsModel.GetContractByUser(userID);
            if (res.getStatus())
            {
                List<Contract> contracts= (List<Contract>)res.getData();

                foreach(Contract contract in contracts)
                {
                    data_sales.Rows.Add(contract.customer.id, contract.car.id, contract.totalPrices, contract.status);
                }
            }
        }

        private void enableForm(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                control.Enabled = true;
            }
        }

        private void disableForm(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                control.Enabled = false;
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            enableForm(gb_user_info);
            cb_shift.Enabled = isAdminRole;
            txt_coefficients_salary.Enabled = isAdminRole;
            txt_id.Enabled = false;
            btn_save_info.Enabled = true;
        }
        private void clearForm()
        {
            foreach (Control control in gb_user_info.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
                else if(control is RichTextBox richTextbox)
                {
                    richTextbox.Text = "";
                }
            }
        }


        private void btn_save_info_Click(object sender, EventArgs e)
        {
            SystemUser user = new SystemUser(txt_id.Text, txt_name.Text, txt_birth.Value, cb_gender.Text, 
                txt_phone.Text, txt_address.Text, txt_identity.Text, cb_shift.Text, double.Parse(txt_coefficients_salary.Text));
            Respond res = UserModel.UpdateUser(user);
            if(res.getStatus())
            {
                btn_save_info.Enabled = false;
                disableForm(gb_user_info);
                LoadSalary();
                MessageBox.Show(res.getDescription());
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_edit_info_Click(object sender, EventArgs e)
        {
            enableForm(gb_account);
            txt_account_id.Enabled = false;
            cb_role.Enabled = isAdminRole;
            btn_save_account.Enabled = true;
        }

        private void btn_save_account_Click(object sender, EventArgs e)
        {
            SystemAccount account = new SystemAccount(txt_account_id.Text, txt_user_name.Text, txt_password.Text, cb_role.Text ,this.userID);
            Respond res = UserModel.UpdateAccount(account);
            if(res.getStatus())
            {
                txt_password.UseSystemPasswordChar = true;
                btn_save_account.Enabled = false;
                disableForm(gb_account);
                MessageBox.Show(res.getDescription());
            }
            else {
                MessageBox.Show(res.getDescription());
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner!= null)
            {
                this.Owner.Show();
            }
        }
    }
}
