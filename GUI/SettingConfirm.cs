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
    public partial class SettingConfirm : Form
    {
        private string userID;

        private string role;
        public SettingConfirm(string userId, string role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            this.userID = userId;
            this.role = role;
        }

        private void SettingConfirm_Load(object sender, EventArgs e)
        {

        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {

            if (show_password.Checked)
            {
                txt_password_confirm.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password_confirm.UseSystemPasswordChar = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Respond res = Authentication.AuthenticationById(this.userID, txt_password_confirm.Text);

            if (res.getStatus())
            {
                Setting form = new Setting(userID, role);
                this.Close();
                form.ShowDialog(this.Owner);
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
