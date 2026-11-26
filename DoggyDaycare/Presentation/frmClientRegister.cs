using DoggyDaycare;
using DoggyDaycare.Business;
using DoggyDaycare.Database;
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
    public partial class frmClientRegister : Form
    {
        private readonly ClientBusinessRules clientRules;
        public frmClientRegister()
        {
            InitializeComponent();
            clientRules = new ClientBusinessRules(new OracleDBClientRepo());
        }

        private void frmClientRegister_Load(object sender, EventArgs e)
        {
            /*
            txtClientID.Text = Clients.getNextClientID().ToString("00");
            txtClientID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true; /* https://stackoverflow.com/questions/28120180/hidden-password-for-c-sharp-login-screen-help-ideas */

            txtClientID.Text = clientRules.GetNextClientId().ToString("000");
            txtClientID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void mnuBackToRegisterPage_Click(object sender, EventArgs e)
        {
            frmRegisterPage backToReg = new frmRegisterPage();
            this.Hide();
            backToReg.ShowDialog();
            this.Close();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtClientID.Text, out int clientID) || clientID <= 0) {
                MessageBox.Show("A valid client ID could not be assigned");
                return;
            }

            try
            {
                clientRules.RegisterClients(clientID, txtFirstName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtPhoneNum.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Client ID " + clientID + " registered successfully!");
            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhoneNum.Clear();
        }

       

        private void btnAccountLogin_Click(object sender, EventArgs e)
        {
            frmClientLogin proceedToLogin = new frmClientLogin();
            this.Hide();
            proceedToLogin.ShowDialog();
            this.Close();
        }
    }
}