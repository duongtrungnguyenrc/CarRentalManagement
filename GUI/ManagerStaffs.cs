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
    public partial class ManagerStaffs : Form
    {
        private string curr_id;
        public ManagerStaffs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            LoadStaffs();
        }

        private void LoadStaffs()
        {
            List<SystemUser> users = UserModel.GetUsers();
            foreach (SystemUser user in users)
            {
                data_staffs.Rows.Add(user.id, user.name, user.birth, user.gender, user.phone, user.address, user.shift, user.identifier, user.coefficientsSalary);
            }
        }

        private void data_staffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_add.Enabled= false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            DataGridViewRow row = data_staffs.Rows[e.RowIndex];
            txt_name.Text = row.Cells["name"].Value.ToString();
            txt_birth.Text = row.Cells["birth"].Value.ToString();
            cb_gender.Text = row.Cells["gender"].Value.ToString();
            txt_phone.Text = row.Cells["phone"].Value.ToString();
            txt_address.Text = row.Cells["address"].Value.ToString();
            cb_shift.Text = row.Cells["shift"].Value.ToString();
            txt_identity.Text = row.Cells["identifier"].Value.ToString();
            txt_coefficients_salary.Text = row.Cells["salary"].Value.ToString();

            this.curr_id = row.Cells["id"].Value.ToString();
        }

        private void ClearForm()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (!(control is Button))
                {
                    control.Text = "";
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show($"Can't add new Staff with null or empty {textBox.Name}", "Error!");
                        return;

                    }
                } 
                else if (control is ComboBox comboBox)
                {
                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        MessageBox.Show($"Can't add new Staff with null or empty {comboBox.Name}", "Error!");
                        return;
                    }
                }
            }



            SystemUser newStaff = new SystemUser("", txt_name.Text, txt_birth.Value, cb_gender.Text,
                txt_phone.Text, txt_address.Text, txt_identity.Text, cb_shift.Text, double.Parse(txt_coefficients_salary.Text));
            Respond res = UserModel.CreateUser(newStaff);
            if(res.getStatus())
            {
                data_staffs.Rows.Clear();
                LoadStaffs();
                MessageBox.Show($"Default granted account: {txt_identity.Text}\nPassword: {txt_phone.Text}", res.getDescription());
            }
            else
            {
                MessageBox.Show(res.getDescription(), "ERROR");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SystemUser updatedStaff = new SystemUser(curr_id, txt_name.Text, txt_birth.Value, cb_gender.Text,
               txt_phone.Text, txt_address.Text, txt_identity.Text, cb_shift.Text, double.Parse(txt_coefficients_salary.Text));
            Respond res = UserModel.UpdateUser(updatedStaff);
            if (res.getStatus())
            {
                data_staffs.Rows.Clear();
                LoadStaffs();
                MessageBox.Show($"Successfully to update {txt_name.Text}");
            }
            else
            {
                MessageBox.Show(res.getDescription(), "ERROR");
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            Respond respond = UserModel.DeleteUser(this.curr_id);
            if (respond.getStatus())
            {
                data_staffs.Rows.Clear();
                LoadStaffs();
                MessageBox.Show(respond.getDescription(), "Successfully to remove user!");
            }
            else
            {
                MessageBox.Show(respond.getDescription(), "Failed to remove user!");

            }
            this.curr_id = "";
        }
    }
}
