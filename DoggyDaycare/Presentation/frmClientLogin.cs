using DoggyDaycare;
using DoggyDaycare.Business;
using DoggyDaycare.Database;
using DoggyDaycare.Presentation;
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
        private readonly ClientBusinessRules clientLogin;
        public frmClientLogin()
        {
            InitializeComponent();
            clientLogin = new ClientBusinessRules(new OracleDBClientRepo());
           
        }


        private void frmClientLogin_Load(object sender, EventArgs e)
        {
            txtEnterPassword.UseSystemPasswordChar = true;
        }



        private void btnAccountLogin_Click(object sender, EventArgs e)
        {
            try
            {
               int clientId = clientLogin.LoginClient(txtEnterEmail.Text.Trim(), txtEnterPassword.Text);
                Clients.LoggedInClientID = clientId;

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Successful Login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            
            DashboardFactory factory = new ClientDashboardFactory();
            Form dashboard = factory.CreateForm();
            {
                dashboard.ShowDialog();
            }
            Clients.LoggedInClientID = 0;
            this.Show();

            
           
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
