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
    public partial class frmCancelReservation : Form
    {
        private readonly BookingBusinessRules bookingOperations;


        public frmCancelReservation()
        {
            InitializeComponent();

            // Ensure that the Presentation Layer can access the business and Database layer
            bookingOperations = new BookingBusinessRules(new OracleDBBookingRepo());
        }

        private void btnSearchResID_Click(object sender, EventArgs e)
        {
            DataTable reservations = bookingOperations.getConfirmedReservation(Clients.LoggedInClientID);
            grdCancelReservation.DataSource = reservations;

            if(reservations.Rows.Count <= 0)
            {
                MessageBox.Show("No confirmed reservations found");
            }
        }

        private int? selectedReservationId;
        private void grdCancelReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Use Case 8 - Step 2 - Step 7: Retrieve Reservation, Kennel, Dog, and Client details + Load UI
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = grdCancelReservation.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row != null)
            {
                return;
            }

            selectedReservationId = Convert.ToInt32(row["ResID"]);
            txtKennelID.Text = row["KennelID"].ToString();
            cboKennelTypes.SelectedIndex = cboKennelTypes.FindStringExact(row["KenneType"].ToString().Trim() + " ");
            txtDogName.Text = row["DogName"].ToString();
            txtDogBreed.Text = row["DogBreed"].ToString();
            txtDogWeight.Text = Convert.ToDecimal(row["DogWeight"]).ToString("0.00");
            dtpCheckIn.Value = Convert.ToDateTime(row["StartDate"]);
            dtpCheckOut.Value = Convert.ToDateTime(row["EndDate"]);
            grpDeleteAReservation.Visible = true;





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
            if(!selectedReservationId.HasValue)
            {
                MessageBox.Show("Please selecta reservation from the grid first!");
                return;

            }

            DialogResult userInput = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(userInput != DialogResult.Yes)
            {
                return;
            }

            int clientId = Clients.LoggedInClientID;

            try
            {
                bookingOperations.CancelReservation(selectedReservationId.Value, clientId);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            selectedReservationId = null;
            grpDeleteAReservation.Visible = false;
            grdCancelReservation.DataSource = bookingOperations.getConfirmedReservation(clientId);

            MessageBox.Show("Reservation cancelled successfully!");
        }
        
    
        

        private void mnuBackToDashboard_Click(object sender, EventArgs e)
        {
            frmUserDashboard dash = new frmUserDashboard();
            dash.ShowDialog();
            this.Close();
        }
    }
}
