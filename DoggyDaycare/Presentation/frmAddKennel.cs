using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoggyDaycare
{
    public partial class frmAddKennel : Form
    {

        private frmMainMenu parent;

        public frmAddKennel()
        {
            InitializeComponent(); // Use Case ID 1 --> Step 1: Begin Add Kennel Function
        }

        public frmAddKennel(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmAddKennel_Load(object sender, EventArgs e)
        {
            // Use Case ID 1 -> Step 6: A Unique Kennel ID is assigned
            txtKennelID.Text = Kennels.getNextKennelID().ToString("000");
            txtKennelID.Enabled = false;
            
            // Use Case ID -> Step 2: Retrieve the KennelTypes from the KennelTypes file
            DataSet dsKennelType = KennelTypes.getKennelTypes();
            cboKennelTypes.Items.Clear();
            for (int i = 0; i < dsKennelType.Tables[0].Rows.Count; i++)
            {
                // Use Case ID 1 --> Step 3: Load on Combobox for Kennel Types
                cboKennelTypes.Items.Add(dsKennelType.Tables[0].Rows[i][0] + " - " + dsKennelType.Tables[0].Rows[i][1]);
            }

            // Use Case ID 1 -> Step 2: Retrieve the KennelCondition from the Kennels file
            DataSet dsKennelCondition = Kennels.getKennelConditions();
            cboKennelCondition.Items.Clear();
            for(int i = 0; i < dsKennelCondition.Tables[0].Rows.Count; i++)
            {
                // Use Case ID 1 -> Step 3: Load on Combobox for Kennel Condition
                cboKennelCondition.Items.Add(dsKennelCondition.Tables[0].Rows[i][0].ToString());
            }

            // Use Case ID 1 -> Step 2: Retrieve the KennelStatus from the Kennels File
            DataSet dsKennelStatus = Kennels.getKennelStatuses();
            cboCurrentStatus.Items.Clear();
            for (int i = 0; i < dsKennelStatus.Tables[0].Rows.Count; i++)
            {
                // Use Case ID 1 -> Step 3: Load on Combobox for Kennel Status
                cboCurrentStatus.Items.Add(dsKennelStatus.Tables[0].Rows[i][0].ToString());
            }
        }


        private void btnAddKennel_Click(object sender, EventArgs e)
        {

            // Use Case ID 1 --> Error Handling: Invalid Daily Rate Value
            try
            {
                if(Convert.ToDecimal(txtDailyRate.Text) <= 0)
                {
                    MessageBox.Show("You must enter a number greater than 0 for the daily rate. Please re-enter!");
                    return;
                }
            }
            catch {
                MessageBox.Show("That isn't a number. Please re-enter a value!");
                return;
            }

            // Use Case ID 1 --> Error Handling: Empty Values
            if (txtKennelDescription.Text.Trim() == "" || cboKennelCondition.SelectedIndex == -1 || cboKennelTypes.SelectedIndex == -1 || cboCurrentStatus.SelectedIndex == -1 || txtDailyRate.Text.Trim() == "")
            {
                MessageBox.Show("All Fields must be entered!");
                return;
            }


            // Use Case ID 1 --> Step 5: Validate Data
            Kennels aKennel = new Kennels(Convert.ToInt32(txtKennelID.Text), cboKennelTypes.Text.Substring(0 , 1), txtKennelDescription.Text, cboKennelCondition.Text,
                Convert.ToDecimal(txtDailyRate.Text), cboCurrentStatus.Text);

            // Use Case ID 1 --> Step 7: Save the object into the Kennels File
            aKennel.addKennel();

            // Use Case ID 1 --> Step 8: Display Confirmation Message
            MessageBox.Show("Kennel " + txtKennelID.Text + " has been added successfully!", "Kennel Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Step 9: Reset UI
            txtKennelID.Text = Kennels.getNextKennelID().ToString("000");
            cboKennelTypes.SelectedIndex = -1;
            txtKennelDescription.Clear();
            cboKennelCondition.SelectedIndex = -1;
            txtDailyRate.Clear();
            cboCurrentStatus.SelectedIndex = -1;
        }
    }
}

