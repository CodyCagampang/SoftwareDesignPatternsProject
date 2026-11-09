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
using DoggyDaycare.Business;
using DoggyDaycare.Database;

namespace DoggyDaycare
{
    public partial class frmBookAKennel : Form
    {
        Kennels theKennel = new Kennels();
        Clients bookClient = new Clients();
        public frmBookAKennel()
        {
            InitializeComponent();
        }

        private void frmBookAKennel_Load(object sender, EventArgs e)
        {
            

            txtClientID.Text = Clients.LoggedInClientID.ToString();
            txtClientID.Enabled = false;


            txtDogID.Text = Dogs.getNextDogID().ToString();
            txtDogID.Enabled = false;

            txtResID.Text = Reservations.getNextReservationID().ToString();
            txtResID.Enabled = false;
            txtFirstName.Text = bookClient.getFirstName();
            txtLastName.Text = bookClient.getLastName();
            txtEmail.Text = bookClient.getEmail();
            txtPhoneNumber.Text = bookClient.getPhoneNumber();

            bookClient.getClient(Clients.LoggedInClientID);
            txtFirstName.Text = bookClient.getFirstName();
            txtFirstName.Enabled = false;
            txtLastName.Text = bookClient.getLastName();
            txtLastName.Enabled = false;
            txtEmail.Text = bookClient.getEmail();
            txtEmail.Enabled = false;
            txtPhoneNumber.Text = bookClient.getPhoneNumber();
            txtPhoneNumber.Enabled = false;
        }

        private void mnuDash_Click(object sender, EventArgs e)
        {
            frmUserDashboard backToDash = new frmUserDashboard();
            backToDash.ShowDialog();
            this.Close();
        }



        private void btnSearchKennel_Click(object sender, EventArgs e)
        {
            if (txtSearchKennelSize.Text.Trim().ToUpper() != "S" && txtSearchKennelSize.Text.Trim().ToUpper() != "M" && txtSearchKennelSize.Text.Trim().ToUpper() != "L")
            {
                MessageBox.Show("Please enter 'S' for Small, 'M' for Medium or 'L' for Large!", "Invalid Search Term", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchKennelSize.Focus();
                return;
            }

            grdViewAvailableKennels.DataSource = Kennels.typeResults(txtSearchKennelSize.Text.Trim().ToUpper()).Tables["Kennels"];
            if (grdViewAvailableKennels.Rows.Count == 1)
            {
                MessageBox.Show("No data found");
                txtSearchKennelSize.Focus();
                return;
            }
            grdViewAvailableKennels.Visible = true;


        }

        private void btnBookKennel_Click(Object sender, EventArgs e)
        {
            String kennelType = grdViewAvailableKennels.CurrentRow.Cells["KennelType"].Value.ToString();
            double dogWeight;

            if(!double.TryParse(txtDogWeight.Text, out dogWeight)) {
                MessageBox.Show("Please enter a valid number for the Dog Weight!", "Invalid Format", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDogWeight.Focus();
                return;
            }

            if(kennelType == "S" && (dogWeight < 1 || dogWeight > 10))
            {
                MessageBox.Show("This kennel is a SMALL. Dogs MUST be between 1 - 10KG", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDogWeight.Focus();
                return;
            }

            else if(kennelType == "M" && (dogWeight > 20))
            {
                MessageBox.Show("This kennel is a MEDIUM. Dogs must be between 11 - 20KG", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDogWeight.Focus();
                return;
            }

            else if(kennelType == "L" && (dogWeight > 60))
            {
                MessageBox.Show("This kennel is a LARGE. Dogs must be between 21 - 59 KG", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDogWeight.Focus();
                return;
            }
            DateTime startDate = dtpCheckIn.Value.Date;
            DateTime endDate = dtpCheckOut.Value.Date;
           

            if (startDate >= endDate)
            {
                MessageBox.Show("End Date must be after Start Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate < DateTime.Now.Date)
            {
                MessageBox.Show("Check In Date must be today or in the future.", "Invalid Date Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            int totalDays = (endDate - startDate).Days;

            if (totalDays < 1 || totalDays > 31)
            {
                MessageBox.Show("The Number of Days must range between 1 - 31 Days!", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double dailyRate = Convert.ToDouble(grdViewAvailableKennels.CurrentRow.Cells["DailyRate"].Value);
            double totalCost = totalDays * dailyRate;
            txtTotalCost.Text = "€" + totalCost.ToString("0.00");
                
            MessageBox.Show("Booking Details: \n" + "Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString() + "\n Total Days: " + totalDays + "\nTotal Price: " + totalCost.ToString("0.00"), "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dogs newDog = new Dogs();
            newDog.setDogID(Dogs.getNextDogID());
            newDog.setClientID(Clients.LoggedInClientID);
            newDog.setDogName(txtDogName.Text);
            newDog.setDogBreed(txtDogBreed.Text);
            newDog.setDogWeight(Convert.ToDouble(txtDogWeight.Text));
            newDog.saveDogDetails();
            
            
            
            Reservations newRes = new Reservations();
            newRes.setResID(Reservations.getNextReservationID());
            newRes.setTotalCost(totalCost);
            newRes.setClientID(Clients.LoggedInClientID);
            newRes.setKennelID(Convert.ToInt32(grdViewAvailableKennels.CurrentRow.Cells["KennelID"].Value));
            newRes.setDogID(newDog.getDogID());
            newRes.setStartDate(startDate);
            newRes.setEndDate(endDate);
            newRes.setResStatus("Confirmed");

            newRes.confirmReservation();
            Kennels.updateKennelStatus(newRes.getKennelID());

            // Reset UI
            txtDogName.Clear();
            txtDogBreed.Clear();
            txtDogWeight.Clear();

            txtDogID.Text = Dogs.getNextDogID().ToString();
            txtResID.Text = Reservations.getNextReservationID().ToString();

            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);


        }


    }
}
    
    
    


