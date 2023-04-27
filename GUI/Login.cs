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
                Main form = new Main((string)respond.getData());
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show((string)respond.getDescription());
            }
        }
    }
}
