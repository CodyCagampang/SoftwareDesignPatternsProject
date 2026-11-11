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
            KennelRepository repository = new KennelRepository();
            KennelOperations operations = new KennelOperations(repository);

            frmAddKennel addKennel = new frmAddKennel(this, operations);
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

        private void mnuBookAKennel_Click(object sender, EventArgs e)
        {
            frmBookAKennel frmBookKennel = new frmBookAKennel();
            this.Hide();
            frmBookKennel.ShowDialog();
            this.Show();
        }

        private void mnuUpdateKennel_Click(object sender, EventArgs e)
        {
            KennelOperations kennelOperations = new KennelOperations(new KennelRepository());
            frmUpdateKennel nextForm = new frmUpdateKennel(this, kennelOperations);
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
