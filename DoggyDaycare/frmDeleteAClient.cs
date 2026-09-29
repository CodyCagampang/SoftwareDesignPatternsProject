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
    public partial class frmDeleteAClient : Form
    {
        frmMainMenu parent;
        Clients aClient = new Clients();

        // UC05 - Step 1: Begin the Remove a Client function
        public frmDeleteAClient()
        {
            InitializeComponent();
        }

        public frmDeleteAClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmListClients_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearchKClientID_Click(object sender, EventArgs e)
        {
            // UC05 - Step 4: Search a Client by their ClientID
            if (txtSearchClientID.Text == "")
            {
                MessageBox.Show("Please enter a Client ID to search.", "Input Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grdClients.DataSource = Clients.findClients(txtSearchClientID.Text).Tables["Clients"];

            // UC05 - Alternate Scenario: No Client ID Found
            if (grdClients.Rows.Count <= 1)
            {
                MessageBox.Show("Client ID Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchClientID.Focus();
                return;
            }

            // UC05 - Step 2: Retrieve all details of the Client’s details from the Clients file
            int clientId = Convert.ToInt32(txtSearchClientID.Text);
            aClient.getClientByID(clientId);

            // UC05 - Step 3: Display UI
            txtFirstName.Text = aClient.getFirstName();
            txtLastName.Text = aClient.getLastName();
            txtEmail.Text = aClient.getEmail();
            txtPhoneNumber.Text = aClient.getPhoneNumber();
            grpClientDetails.Visible = true;

            grdClients.Visible = true;
        }

        private void grdClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // UC05 - Step 6: Select the ClientID
            if (e.RowIndex >= 0)
            {
                int clientId = Convert.ToInt32(grdClients.Rows[e.RowIndex].Cells[0].Value.ToString());

                aClient.getClientByID(clientId);

                txtFirstName.Text = aClient.getFirstName();
                txtLastName.Text = aClient.getLastName();
                txtEmail.Text = aClient.getEmail();
                txtPhoneNumber.Text = aClient.getPhoneNumber();

                grpClientDetails.Visible = true;
            }
        }

        private void btnRemoveAClient_Click(object sender, EventArgs e)
        {
            // UC05 - Step 5: Retrieve Reservation Details from the Reservations File
            // UC05 - Step 7: Validate Data (No active or future reservations)
            if (Clients.hasActiveRegistration(aClient.getClientID()) > 0)
            {
                MessageBox.Show("This client has active reservations and cannot be deleted.", "Active Reservations Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       

            // UC05 - Step 6: Select and ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to Delete this Client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // UC05 - Step 8: Remove the client’s details from the Clients file
                aClient.deleteClient();

                // UC05 - Step 9: Display Confirmation Message
                MessageBox.Show("Client has successfully been removed from the system!", "Client has been removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // UC05 - Step 10: Reset UI
                grpClientDetails.Visible = false;
                grdClients.Visible = false;
                txtSearchClientID.Clear();
                txtSearchClientID.Focus();
            }
        }
    }
}
