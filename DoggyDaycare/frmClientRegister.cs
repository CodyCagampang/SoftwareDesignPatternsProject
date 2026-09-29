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
    public partial class frmClientRegister : Form
    {
        public frmClientRegister()
        {
            InitializeComponent();
        }

        private void frmClientRegister_Load(object sender, EventArgs e)
        {
            txtClientID.Text = Clients.getNextClientID().ToString("00");
            txtClientID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true; /* https://stackoverflow.com/questions/28120180/hidden-password-for-c-sharp-login-screen-help-ideas */
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
            
            if (txtEmail.Text == "" || txtFirstName.Text == "" || txtSurname.Text == "" || txtPassword.Text == "" || txtPhoneNum.Text == "")
            {
                MessageBox.Show("All Fields must be entered!", "Enter Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the textbox is only digits
            bool onlyDigits = true;
            foreach (char c in txtPhoneNum.Text)
            {
                if (!char.IsDigit(c))
                {
                    onlyDigits = false;
                    break;
                }
            }

            // Check the Phone Number is ONLY digits and has a valid number of digits
            if (txtPhoneNum.Text.Length < 9 || txtPhoneNum.Text.Length > 12 || onlyDigits == false)
            {
                MessageBox.Show("Please enter a valid Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNum.Focus();
                return;
            }

            // Check that the email only has ONE '@' symbol
            int count = 0;
            foreach (char c in txtEmail.Text)
            {
                if (c == '@')
                {
                    count++;
                }

            }

            // If email does NOT have 1 '@' symbol, Validate
            if (count != 1)
            {
                MessageBox.Show("Please enter a valid email!", "Invalid Email Format", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Ensure Password is at LEAST 8 characters long
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("The password must have at LEAST 8 characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if an email already exists in the Database
            if (Clients.checkExistingEmails(txtEmail.Text.Trim()) > 0)
            {
                {
                    MessageBox.Show("This email is already being used!. Please enter a new email", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Clients aClient = new Clients(
                Convert.ToInt32(txtClientID.Text),
                txtFirstName.Text,
                txtSurname.Text,
                txtEmail.Text,
                txtPassword.Text,
                txtPhoneNum.Text);

            aClient.registerClient();

            MessageBox.Show("Client ID " + txtClientID.Text + " has been successfully added!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset The From After Button Is Clicked
            txtClientID.Text = Clients.getNextClientID().ToString("00");
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