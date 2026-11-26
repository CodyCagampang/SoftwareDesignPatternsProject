using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoggyDaycare.Business;
using DoggyDaycare.Database;

namespace DoggyDaycare
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuAddKennel_Click(object sender, EventArgs e)
        {
            OracleDBKennelRepo repository = new OracleDBKennelRepo();
            KennelBusinessRules operations = new KennelBusinessRules(repository);

            frmAddKennel addKennel = new frmAddKennel(this, operations);
            this.Hide();
            addKennel.ShowDialog();
            this.Show();
        }

        

        private void mnuBookAKennel_Click(object sender, EventArgs e)
        {
            frmBookAKennel frmBookKennel = new frmBookAKennel();
            this.Hide();
            frmBookKennel.ShowDialog();
            this.Show();
        }

        private void mnuUpdateKennel_Click(object sender, EventArgs e)
        {
            KennelBusinessRules kennelOperations = new KennelBusinessRules(new OracleDBKennelRepo());
            frmUpdateKennel nextForm = new frmUpdateKennel(this, kennelOperations);
            this.Hide();
            nextForm.ShowDialog();
        }


        

        private void mnuListAllClients_Click(object sender, EventArgs e)
        {
            frmListAllClients listClients = new frmListAllClients();
            this.Hide();
            listClients.ShowDialog();
            this.Show();
        }
    }
}
