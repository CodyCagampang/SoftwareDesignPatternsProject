using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoggyDaycare.Business;

namespace DoggyDaycare
{
    public partial class frmAddKennel : Form
    {

        private frmMainMenu parent;
        private readonly KennelOperations kennelOperations;

        public frmAddKennel()
        {
            InitializeComponent(); // Use Case ID 1 --> Step 1: Begin Add Kennel Function
        }

        public frmAddKennel(frmMainMenu parent, KennelOperations kennelOperations)
        {
            InitializeComponent();
            this.parent = parent;
            this.kennelOperations = kennelOperations;
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

            List<KennelTypeOptions> types = kennelOperations.GetKennelTypes();
            cboKennelTypes.Items.Clear();

            foreach (KennelTypeOptions type in types)
            {
                cboKennelTypes.Items.Add(type.TypeCode + " - " + type.Description);
            }




            List<String> conditions = kennelOperations.GetKennelConditions();
            cboKennelCondition.Items.Clear();

            foreach(String condition in conditions)
            {
                cboKennelCondition.Items.Add(condition);
            }

            List<String> statuses = kennelOperations.GetKennelStatus();
            cboCurrentStatus.Items.Clear();

            foreach(String status in statuses)
            {
                cboCurrentStatus.Items.Add(status);
            }
        }


        private void btnAddKennel_Click(object sender, EventArgs e)
        {
            if (!kennelOperations.IsDescriptionValid(txtKennelDescription.Text) || cboKennelTypes.SelectedIndex == -1 || cboKennelCondition.SelectedIndex == -1 || cboCurrentStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDailyRate.Text)) 
               
            {
                MessageBox.Show("All Fields must be entered!");
                return;
            } 


            if(!decimal.TryParse(txtDailyRate.Text, out decimal dailyRate))
            {
                MessageBox.Show("That isn't a number. Please re-enter a value!");
                return;
            }

            if (!kennelOperations.IsDailyRateValid(dailyRate))
            {
                MessageBox.Show("You must enter a daily rate greater than zero.");
                return;
            }
            Kennels aKennel = new Kennels(Convert.ToInt32(txtKennelID.Text), cboKennelTypes.Text.Substring(0, 1), txtKennelDescription.Text.Trim(), cboKennelCondition.Text, dailyRate, cboCurrentStatus.Text);
            try
            {
                kennelOperations.AddKennel(aKennel);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Kennel " + txtKennelID.Text + " has been added successfully!");
        }
    }
}

