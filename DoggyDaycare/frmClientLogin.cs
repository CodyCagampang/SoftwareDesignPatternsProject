using DoggyDaycare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyDaycare
{
    public partial class frmClientLogin : Form
    {
        public frmClientLogin()
        {
            InitializeComponent();
        }


        private void frmClientLogin_Load(object sender, EventArgs e)
        {
            txtEnterPassword.UseSystemPasswordChar = true;
        }



        private void btnAccountLogin_Click(object sender, EventArgs e)
        {
            if (Clients.clientLogin(txtEnterEmail.Text.Trim(), txtEnterPassword.Text.Trim()) > 0)
            {
                Clients loggedClients = new Clients();
                loggedClients.getClientEmail(txtEnterEmail.Text);
                Clients.LoggedInClientID = loggedClients.getClientID();

                MessageBox.Show("Successful Login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmUserDashboard dashboard = new frmUserDashboard();
                dashboard.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }


        private void mnuBackToRegisterDetails_Click(object sender, EventArgs e)
        {
            frmClientRegister backToRegister = new frmClientRegister();
            this.Hide();
            backToRegister.ShowDialog();
            this.Close();
        }
    }

}
