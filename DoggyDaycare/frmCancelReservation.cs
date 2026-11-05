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
    public partial class frmCancelReservation : Form
    {

        public frmCancelReservation()
        {
            InitializeComponent();
        }

        // Use Case 8 - Step 6: The Client searches the associated Reservation ID
        private void btnSearchResID_Click(object sender, EventArgs e)
        {
            DataSet ds = Reservations.retrieveAllReservations(Clients.LoggedInClientID);

            if (ds.Tables["Reservations"].Rows.Count == 0)
            {
                MessageBox.Show("There are no active registrations!", "No Data to show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdCancelReservation.DataSource = ds.Tables["Reservations"];
        }

        private void grdCancelReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Use Case 8 - Step 2 - Step 7: Retrieve Reservation, Kennel, Dog, and Client details + Load UI





            // When the user clicks on a grid, Take the value from the first Column and convert it into an integer
            int resID = Convert.ToInt32(grdCancelReservation.Rows[grdCancelReservation.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Reservations selectedReservation = new Reservations();
            selectedReservation.getReservation(resID);

            Dogs selectedDogs = new Dogs();
            selectedDogs.getDog(selectedReservation.getDogID());

            Kennels selectedKennels = new Kennels();
            selectedKennels.getKennel(selectedReservation.getKennelID());

            txtKennelID.Text = selectedReservation.getKennelID().ToString();
            txtDogName.Text = selectedDogs.getDogName();
            txtDogBreed.Text = selectedDogs.getDogBreed();
            txtDogWeight.Text = selectedDogs.getDogWeight().ToString("0.0");

            cboKennelTypes.Text = selectedKennels.getKennelType();
            txtDailyRate.Text = selectedKennels.getDailyRate().ToString("0.00");

            dtpCheckIn.Value = selectedReservation.getStartDate();
            dtpCheckOut.Value = selectedReservation.getEndDate();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            int resID = Convert.ToInt32(grdCancelReservation.CurrentRow.Cells[0].Value);

            Reservations reservations = new Reservations();
            reservations.getReservation(resID);

            // Check if Status is Confirmed
            if (reservations.getResStatus() != "Confirmed")
            {
                MessageBox.Show("Reservation must be set to 'Confirmed' before it can be cancelled", "Invalid Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use Case 8 - Step 8: Validate Cancellation is at least 72 hours before start date
            if ((reservations.getStartDate() - DateTime.Now).TotalHours < 72)
            {
                MessageBox.Show("The cancellation period has exceeded! All cancellations must be made 72 hours beforehand", "Cancellation Period Overdue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use Case 8 - Step 10: Display a final warning message
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Use Case 8 - Step 11: Update Status from "Confirmed" to "Cancelled"
                reservations.setResStatus("Cancelled");
                reservations.updateReservationStatus();

                Kennels.updateKennelStatusAfterCancellation(reservations.getKennelID());

                // Step 12: Reset UI
                MessageBox.Show("Reservation cancelled successfully!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKennelID.Clear();
                txtDogName.Clear();
                txtDogBreed.Clear();
                txtDogWeight.Clear();
                cboKennelTypes.SelectedIndex = -1;
                txtDailyRate.Clear();
                dtpCheckIn.Value = DateTime.Now;
                dtpCheckOut.Value = DateTime.Now.AddDays(1);

                DataSet ds = Reservations.retrieveAllReservations(Clients.LoggedInClientID);
                grdCancelReservation.DataSource = ds.Tables["Reservations"];
            }
        }

        private void mnuBackToDashboard_Click(object sender, EventArgs e)
        {
            frmUserDashboard dash = new frmUserDashboard();
            dash.ShowDialog();
            this.Close();
        }
    }
}
