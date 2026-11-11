using DoggyDaycare.Business;
using DoggyDaycare.Database;
using Microsoft.VisualBasic.Logging;
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
    public partial class frmBookAKennel : Form
    {
        Kennels theKennel = new Kennels();
        Clients bookClient = new Clients();
        private readonly KennelOperations kennelOperations;
        private readonly BookingOperations bookingOperations;
        private readonly DogBusinessRules dogBusinessRules;
      
        

        public frmBookAKennel()
        {
            InitializeComponent();

            this.kennelOperations = new KennelOperations(new KennelRepository());
            bookingOperations = new BookingOperations(new BookingRepository());
            dogBusinessRules = new DogBusinessRules();
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

            String size = txtSearchKennelSize.Text.Trim().ToUpper();
            if (!kennelOperations.isKennelSizeValid(size))
            {
                MessageBox.Show("Please enter 'S' for Small, 'M' for Medium or 'L' for Large!", "Invalid Search Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchKennelSize.Focus();
                return;


            }
            
            List<AvailableKennel> kennels = kennelOperations.GetAvailableKennels(size);

            grdViewAvailableKennels.DataSource = kennels;
            grdViewAvailableKennels.ReadOnly = true;
            grdViewAvailableKennels.AllowUserToAddRows = false;
            grdViewAvailableKennels.Visible = kennels.Count > 0;

            if (kennels.Count == 0)
            {
                MessageBox.Show("No Kennels Available");
                txtSearchKennelSize.Focus();
                return;
            }

           
        }

        private void btnBookKennel_Click(Object sender, EventArgs e)
        {
            if(grdViewAvailableKennels.CurrentRow == null || grdViewAvailableKennels.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an available kennel first");
                return;
            }
            
            String kennelType = grdViewAvailableKennels.CurrentRow.Cells["KennelType"].Value.ToString();
            if (!double.TryParse(txtDogWeight.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid number for the Dog Weight!", "Invalid Format", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtDogWeight.Focus();
                return;
            }

            try
            {
                dogBusinessRules.ValidateDogWeight(txtDogName.Text, txtDogBreed.Text, weight);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }





            if (!bookingOperations.isWeightValid(kennelType, weight))
            {
                MessageBox.Show("The dog's weight is outside the range for this kennel.", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDogWeight.Focus();
                return;
            }


            DateTime startDate = dtpCheckIn.Value.Date;
            DateTime endDate = dtpCheckOut.Value.Date;

            int totalDays;

            try
            {
                totalDays = bookingOperations.GetTotalDays(startDate, endDate, DateTime.Today);
            }
            catch (ArgumentException ex)
            {
               MessageBox.Show(ex.Message);
                return;
            }

            Dogs dogs = new Dogs();
            dogs.setClientID(Clients.LoggedInClientID);
            dogs.setDogName(txtDogName.Text.Trim());
            dogs.setDogBreed(txtDogBreed.Text.Trim());  
            dogs.setDogWeight(weight);

            Reservations reservation = new Reservations();
            reservation.setClientID(Clients.LoggedInClientID);
            reservation.setKennelID(Convert.ToInt32(grdViewAvailableKennels.CurrentRow.Cells["KennelID"].Value));
            reservation.setStartDate(dtpCheckIn.Value.Date);
            reservation.setEndDate(dtpCheckOut.Value.Date);

            string selectedKennelType = grdViewAvailableKennels.CurrentRow.Cells["KennelType"].Value.ToString();
            decimal selectedDailyRate = Convert.ToDecimal(grdViewAvailableKennels.CurrentRow.Cells["DailyRate"].Value);


            int reservationID;
            try
            {
                decimal totalCost = bookingOperations.CalculateTotalCost(totalDays, selectedDailyRate);
                reservationID = bookingOperations.BookKennel(dogs, reservation, selectedKennelType, selectedDailyRate);
                txtTotalCost.Text = "€" + totalCost.ToString("0.00");
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

            MessageBox.Show("Reservation " + reservationID + " booked successfully!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
    
    
    


