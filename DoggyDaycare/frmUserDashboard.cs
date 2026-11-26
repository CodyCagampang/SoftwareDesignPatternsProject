using DoggyDaycare;
using DoggyDaycare.Presentation;
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
    public partial class frmUserDashboard : Form
    {
        private frmClientLogin frmClientLogin;

       

        public frmUserDashboard()
        {
            InitializeComponent();
        }

        public frmUserDashboard(frmClientLogin frmClientLogin)
        {
            this.frmClientLogin = frmClientLogin;
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Clients.LoggedInClientID = 0;
            this.Close();
            

        }

        private void mnuBookKennel_Click(object sender, EventArgs e)
        {
            using (frmBookAKennel book = new frmBookAKennel())
            {
                book.ShowDialog(this);
            }
        }

        private void mnuCancelReservation_Click(object sender, EventArgs e)
        {
            using (frmCancelReservation cancel = new frmCancelReservation())
            {
                cancel.ShowDialog(this);
            }

        }

        private void mnuUpdateClientDetails_Click(object sender, EventArgs e)
        {
            using (frmUpdateAccount updateForm = new frmUpdateAccount())
            {
                updateForm.ShowDialog(this);
            }
        }
    }
}
