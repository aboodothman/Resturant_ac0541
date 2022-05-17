using FrmDBProject.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDBProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            if (Dblib.verifyUserNamePassword(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Welcome Abood1");
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من الخروج", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
