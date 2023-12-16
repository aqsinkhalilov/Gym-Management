using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPasswd.Text;   
            if(txtUserName.Text == "admin" && txtPasswd.Text == "admin")
            {
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
