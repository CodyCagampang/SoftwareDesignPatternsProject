using DoggyDaycare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyDaycare
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            txtAdminPassword.UseSystemPasswordChar = true;
        }

        private void mnuRegsiter_Click(object sender, EventArgs e)
        {
            frmRegisterPage regpage = new frmRegisterPage();
            this.Hide();
            regpage.ShowDialog();
            this.Close();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            String adminUserName = "admin";
            String adminPassword = "password";

            if (txtAdminName.Text == adminUserName && txtAdminPassword.Text == adminPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMainMenu mnu = new frmMainMenu();
                mnu.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid username or password. Please try again", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtAdminPassword.Clear();
                txtAdminName.Clear();
            }
        }

        
    }
}
