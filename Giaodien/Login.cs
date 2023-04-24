using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
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
            Respond respond = authOBJ.LoginAuth(Connection.GetConnection());
            if (respond.getStatus()) {
              //  MessageBox.Show((string)respond.getData());
                Main form = new Main();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show((string)respond.getDescription());
            }
        }
    }
}
