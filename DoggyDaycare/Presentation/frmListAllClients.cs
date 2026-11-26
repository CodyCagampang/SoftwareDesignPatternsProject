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
using System.Windows.Forms.VisualStyles;

namespace DoggyDaycare
{
    public partial class frmListAllClients : Form
    {
        private readonly ClientBusinessRules listClients;
        public frmListAllClients()
        {
            InitializeComponent();
            listClients = new ClientBusinessRules(new OracleDBClientRepo());
        }

        private void frmListAllClients_Load(object sender, EventArgs e)
        {
            grdViewClients.ReadOnly = true;
            grdViewClients.AllowUserToAddRows = false;
            grdViewClients.DataSource = listClients.GetAllClients();
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();

        }

        

        private void grdViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
