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

namespace DoggyDaycare.Presentation
{
    public partial class frmUpdateAccount : Form
    {
        private readonly ClientBusinessRules updateClientDetails = new ClientBusinessRules(new OracleDBClientRepo());
        public frmUpdateAccount()
        {
            InitializeComponent();
        }

        private void mnuBackToMain_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Close();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                updateClientDetails.UpdateClientDetails(Clients.LoggedInClientID, txtFirstName.Text, txtSurname.Text, txtEmail.Text, txtPhoneNum.Text);
                MessageBox.Show("Your details have been saved");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
