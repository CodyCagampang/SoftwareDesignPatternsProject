using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoggyDaycare.Business;
using DoggyDaycare.Database;

namespace DoggyDaycare
{
    public partial class frmUpdateKennel : Form
    {
        frmMainMenu parent;
        Kennels theKennel = new Kennels();
        private readonly KennelOperations kennelOperations;
        public frmUpdateKennel()
        {
            InitializeComponent(); // Begin the Update a Kennel Function
        }

        public frmUpdateKennel(frmMainMenu Parent, KennelOperations kennelOperations)
        {
            InitializeComponent();
            parent = Parent;
            this.kennelOperations = kennelOperations;
        }

        private void btnSearchKennelID_Click(object sender, EventArgs e)
        {

            // Use Case ID 3 --> Step 4: Search the KennelID
           grdUpdateKennel.DataSource = Kennels.findKennels(txtKennelID.Text).Tables["Kennels"];
            if (grdUpdateKennel.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
                txtKennelID.Focus();
                return;
            }

            grdUpdateKennel.Visible = true;
        }

        private void grdUpdateKennel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int Id = Convert.ToInt32(grdUpdateKennel.Rows[grdUpdateKennel.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theKennel.getKennel(Id);

            // Use Case ID 3 --> Step 4: 
            cboKennelTypes.Text = theKennel.getKennelType();
            txtKennelDescription.Text = theKennel.getKennelDescription();
            cboKennelCondition.Text = theKennel.getKennelCondition();
            txtDailyRate.Text = theKennel.getDailyRate().ToString("0.00");

            DataSet types = KennelTypes.getKennelTypes();
            int typeIndex = 0;
            cboKennelTypes.Items.Clear();
            for (int i = 0; i < types.Tables[0].Rows.Count; i++)
            {
                cboKennelTypes.Items.Add(types.Tables[0].Rows[i][0] + " - " + types.Tables[0].Rows[i][1]);
                if (types.Tables[0].Rows[i][0].Equals(theKennel.getKennelType())) typeIndex = i;
            }

            cboKennelTypes.SelectedIndex = typeIndex;
            grpKennel.Visible = true;
            DataSet condition = Kennels.getKennelConditions();
            int conditionIndex = 0;
            cboKennelCondition.Items.Clear();
            for (int i = 0; i < condition.Tables[0].Rows.Count; i++)
            {
                cboKennelCondition.Items.Add(condition.Tables[0].Rows[i][0]);
                if (condition.Tables[0].Rows[i][0].Equals(theKennel.getKennelCondition())) conditionIndex = i;
            }

            cboKennelCondition.SelectedIndex = conditionIndex;
            grpKennel.Visible = true;
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

        private void btnUpdateKennel_Click(object sender, EventArgs e)
        {
            // Validation --> Ensure that specific KennelID has no active Registrations
            if (Reservations.getReservationCount(theKennel.getKennelID()) > 0)
            {
                MessageBox.Show("This Specific Kennel is actively registered. Please select a different kennel", "Unable to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use Case ID 3 --> Step 5: Update Relevant Data
            theKennel.setKennelType(cboKennelTypes.Text.Substring(0, 1));
            theKennel.setKennelDescription(txtKennelDescription.Text);
            theKennel.setKennelCondition(cboKennelCondition.Text);
            theKennel.setDailyRate(Convert.ToDecimal(txtDailyRate.Text));
            theKennel.setStatus(cboCurrentStatus.Text);

            theKennel.updateKennel();
            MessageBox.Show("Kennel Updated!", "Updating Kennel", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpKennel.Visible = false;
            txtKennelID.Clear();
            txtKennelID.Focus();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void txtKennelID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateKennel_Load(object sender, EventArgs e)
        {

        }
    }
}
