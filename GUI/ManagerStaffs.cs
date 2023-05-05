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
            DataModel model = new DataModel();
            List<SystemUser> users = model.GetStaffs();
            foreach (SystemUser user in users)
            {
                data_staffs.Rows.Add(user.id, user.name, user.birth, user.gender, user.phone, user.address, user.shift, user.identifier, user.coefficientsSalary);
            }
        }

        private void ManagerStaffs_Load(object sender, EventArgs e)
        {
           
        }

        private void data_staffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_add.Enabled= false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            DataGridViewRow row = data_staffs.Rows[e.RowIndex];
            txt_name.Text = row.Cells["name"].Value.ToString();
            txt_birth.Text = row.Cells["birth"].Value.ToString();
            cb_gender.Text = row.Cells["gender"].Value.ToString();
            txt_phone.Text = row.Cells["phone"].Value.ToString();
            txt_address.Text = row.Cells["address"].Value.ToString();
            txt_shift.Text = row.Cells["shift"].Value.ToString();
            txt_identity.Text = row.Cells["identifier"].Value.ToString();
            txt_coefficients_salary.Text = row.Cells["salary"].Value.ToString();

            this.curr_id = row.Cells["id"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataModel model = new DataModel();
            Respond respond = model.DeleteStaff(this.curr_id);
            if(respond.getStatus())
            {
                MessageBox.Show(respond.getDescription(), "Success!");
            }
            else
            {
                MessageBox.Show(respond.getDescription(), "Fail!");

            }
            this.curr_id = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SystemUser editStaff = new SystemUser(curr_id, txt_name.Text, txt_birth.Value, cb_gender.Text,
               txt_phone.Text, txt_address.Text, txt_identity.Text, txt_shift.Text,double.Parse(txt_coefficients_salary.Text));
            DataModel model = new DataModel();
            Respond res = model.UpdateStaff(editStaff);
            data_staffs.Refresh();
            MessageBox.Show($"Default granted account: {txt_identity.Text}\nPassword: {txt_phone.Text}", res.getDescription());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
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
                txt_phone.Text, txt_address.Text, txt_identity.Text, txt_shift.Text, double.Parse(txt_coefficients_salary.Text));
            DataModel model = new DataModel();
            Respond res = model.InsertStaff(newStaff);
            data_staffs.Refresh();
            MessageBox.Show($"Default granted account: {txt_identity.Text}\nPassword: {txt_phone.Text}", res.getDescription());
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
