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
    public partial class frmDeleteKennel : Form
    {
        Kennels theKennel = new Kennels();

        public frmDeleteKennel()
        {
            InitializeComponent(); // Use Case ID 2 --> Step 1: Begin Delete a Kennel Function
        }

        public frmDeleteKennel(frmMainMenu parent)
        {
            InitializeComponent();

        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenuAdmin = new frmMainMenu();
            this.Hide();
            frmMainMenuAdmin.ShowDialog();
            this.Close();

        }

        private void btnSearchKennelID_Click(object sender, EventArgs e)
        {
            if (txtKennelID.Text.Trim() == "")
            {
                MessageBox.Show("Empty Value entered. Please enter a Kennel ID!");
                return;
            }
            

            // Use Case ID 2 --> Error Handling: Kennel ID Not Found
            DataSet ds = Kennels.findKennels(txtKennelID.Text);
            if (ds.Tables["Kennels"].Rows.Count <= 0)
            {
                MessageBox.Show("Kennel ID Not found. Please re-enter an existing value", "Non-Existent KennelID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKennelID.Focus();
               
                grdDeleteKennel.Visible = false;
                return;
            }
                // Use Case ID 2 --> Step 3: Display UI
                grdDeleteKennel.DataSource = ds.Tables["Kennels"];
                grdDeleteKennel.Visible = true;
            }
        

        private void grdDeleteKennel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdDeleteKennel.Rows[grdDeleteKennel.CurrentCell.RowIndex].Cells[0].Value.ToString());
            theKennel.getKennel(Id);

            cboKennelTypes.Text = theKennel.getKennelType();
            cboKennelTypes.Enabled = false; // Ensure fields cannot be changed 
            txtKennelDescription.Text = theKennel.getKennelDescription();
            txtKennelDescription.Enabled = false; // Ensure fields cannot be changed 
            cboKennelCondition.Text = theKennel.getKennelCondition();
            cboKennelCondition.Enabled = false; // Ensure fields cannot be changed 
            txtDailyRate.Text = theKennel.getDailyRate().ToString("0.00");
            txtDailyRate.Enabled = false; // Ensure fields cannot be changed 
            cboCurrentStatus.Text = theKennel.getStatus();
            cboCurrentStatus.Enabled = false; // Ensure fields cannot be changed 

            DataSet types = KennelTypes.getKennelTypes();
            int typeIndex = 0;
            cboKennelTypes.Items.Clear();
            for (int i = 0; i < types.Tables[0].Rows.Count; i++)
            {
                cboKennelTypes.Items.Add(types.Tables[0].Rows[i][0] + " - " + types.Tables[0].Rows[i][1]);
                if (types.Tables[0].Rows[i][0].Equals(theKennel.getKennelType())) typeIndex = i;
            }

            cboKennelTypes.SelectedIndex = typeIndex;

            DataSet condition = Kennels.getKennelConditions();
            int conditionIndex = 0;
            cboKennelCondition.Items.Clear();
            for (int i = 0; i < condition.Tables[0].Rows.Count; i++)
            {
                cboKennelCondition.Items.Add(condition.Tables[0].Rows[i][0]);
                if (condition.Tables[0].Rows[i][0].Equals(theKennel.getKennelCondition())) conditionIndex = i;
            }

            cboKennelCondition.SelectedIndex = conditionIndex;

            DataSet status = Kennels.getKennelStatuses();
            int statusIndex = 0;
            cboCurrentStatus.Items.Clear();
            for (int i = 0; i < status.Tables[0].Rows.Count; i++)
            {
                cboCurrentStatus.Items.Add(status.Tables[0].Rows[i][0]);
                if (status.Tables[0].Rows[i][0].Equals(theKennel.getStatus())) statusIndex = i;
            }
            cboCurrentStatus.SelectedIndex = statusIndex;
            grpKennel.Visible = true;
        }




        private void btnDeleteKennel_Click(object sender, EventArgs e)
        {
            if (txtKennelID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Kennel ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKennelID.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this kennel?", "Delete Kennel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (Reservations.getReservationCount(theKennel.getKennelID()) > 0)
                {
                    MessageBox.Show("This kennel is linked to a reservation and cannot be deleted.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                theKennel.deleteKennel();
                MessageBox.Show("Kennel deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpKennel.Visible = false;
                grdDeleteKennel.Visible = false;
                txtKennelID.Clear();
                txtKennelID.Focus();
            }
        }


        private void frmDeleteKennel_Load(object sender, EventArgs e)
        {

        }

        
     
    }
}


