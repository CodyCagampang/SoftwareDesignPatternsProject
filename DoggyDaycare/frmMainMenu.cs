using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            frmAddKennel addKennel = new frmAddKennel(this);
            this.Hide();
            addKennel.ShowDialog();
            this.Show();
        }

        private void mnuRemoveKennel_Click(object sender, EventArgs e)
        {
            frmDeleteKennel frmDeleteKennel = new frmDeleteKennel(this);
            this.Hide();
            frmDeleteKennel.ShowDialog();
        }

        private void mnuUpdateKennel_Click(object sender, EventArgs e)
        {
            frmUpdateKennel nextForm = new frmUpdateKennel(this);
            this.Hide();
            nextForm.ShowDialog();
        }


        private void mnuDeRegisterClient_Click(object sender, EventArgs e)
        {
            frmDeleteAClient deleteAClient = new frmDeleteAClient(this);
            this.Hide();
            deleteAClient.ShowDialog();
            this.Show();
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
