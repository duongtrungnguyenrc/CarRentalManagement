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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Authentication authOBJ = new Authentication(txt_user.Text, txt_password.Text);
            Respond respond = authOBJ.LoginAuth();
            if (respond.getStatus()) {
                List<string> data = (List<string>) respond.getData();
                Main form = new Main(data[0], data[1], data[2]);
                clearForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show((string)respond.getDescription());
            }
        }

        private void clearForm()
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
