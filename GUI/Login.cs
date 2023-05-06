using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Respond res = Authentication.LoginAuth(txt_user.Text, txt_password.Text);
            if (res.getStatus()) {
                List<string> data = (List<string>) res.getData();
                Main form = new Main(data[0], data[1], data[2]);
                ClearForm();
                this.Hide();
                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show((string)res.getDescription());
            }
        }

        private void ClearForm()
        {
            txt_password.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(show_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
