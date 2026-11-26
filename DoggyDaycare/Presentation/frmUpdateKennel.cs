using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoggyDaycare.Business;
namespace DoggyDaycare
{
    
    public partial class frmUpdateKennel : Form
    {
        frmMainMenu parent;
        Kennels theKennel = new Kennels();
        private readonly KennelBusinessRules kennelOperations;
        public frmUpdateKennel()
        {
            InitializeComponent(); // Begin the Update a Kennel Function
        }

        public frmUpdateKennel(frmMainMenu Parent, KennelBusinessRules kennelOperations)
        {
            InitializeComponent();
            parent = Parent;
            this.kennelOperations = kennelOperations;
        }

        private void frmUpdateKennel_Load(object sender, EventArgs e)
        {
            foreach (var type in kennelOperations.GetKennelTypes())
            {
                cboKennelTypes.Items.Add(type.TypeCode + " - " + type.Description);
            }

            foreach(var condition in kennelOperations.GetKennelConditions())
            {
                cboKennelCondition.Items.Add(condition);
            }

            foreach(var currentStatus in kennelOperations.GetKennelStatus())
            {
                cboCurrentStatus.Items.Add(currentStatus);
            }

        }

        private void btnSearchKennelID_Click(object sender, EventArgs e)
        {

            if(!int.TryParse(txtKennelID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Please enter a valid kennel ID as an integer");
                return;
            }

            DataTable results = kennelOperations.SearchKennelById(id);

            if (results.Rows.Count == 0)
            {
                MessageBox.Show("No kennel found with that ID");
                return;
            }

            grdUpdateKennel.Visible = true;
            grdUpdateKennel.DataSource = results;
        }

        private int? selectedKennelId;
        private void grdUpdateKennel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            var row = grdUpdateKennel.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) {
                return;
            }

            selectedKennelId = Convert.ToInt32(row["KennelID"]);
            cboKennelTypes.SelectedIndex = cboKennelTypes.FindString(row["KennelType"].ToString().Trim() + " ");
            txtKennelDescription.Text = row["Description"].ToString();
            cboKennelCondition.SelectedIndex = cboKennelCondition.FindStringExact(row["KennelCondition"].ToString().Trim());
            txtDailyRate.Text = Convert.ToDecimal(row["DailyRate"]).ToString("0.00");
            cboCurrentStatus.SelectedIndex = cboCurrentStatus.FindString(row["Status"].ToString());
            grpKennel.Visible = true;
        }

        private void btnUpdateKennel_Click(object sender, EventArgs e)
        {
            if (!selectedKennelId.HasValue)
            {
                MessageBox.Show("Please selecr a kennel to update");
                return;
            }

            if (cboKennelTypes.SelectedIndex < 0 || cboKennelCondition.SelectedIndex < 0 || cboCurrentStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Kennel Type, a Condition and a Status");
                return;
            }

            if (!decimal.TryParse(txtDailyRate.Text, out decimal dailyRate))
            {
                MessageBox.Show("Please enter a valid value for the daily rate");
                return;
            }

            var updatedKennel = new Kennels(selectedKennelId.Value, cboKennelTypes.Text.Substring(0, 1), txtKennelDescription.Text.ToString().Trim(), cboKennelCondition.Text, dailyRate, cboCurrentStatus.Text);

            try
            {
                kennelOperations.UpdateKennel(updatedKennel);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            catch (InvalidOperationException invalid)
            {
                MessageBox.Show(invalid.Message);
                return;
            }

            MessageBox.Show("Kennel Updated");
            selectedKennelId = null;
            grpKennel.Visible = false;
            grdUpdateKennel.DataSource = null;
            grdUpdateKennel.Visible = false;
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
            // The Kennel ID Changes automatically after updating a kenne;
        }

        
    }
}
