using DoggyDaycare;
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
            frmClientLogin logout = new frmClientLogin();
            this.Close();
            logout.ShowDialog();
            this.Show();

        }

        private void mnuBookKennel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookAKennel book = new frmBookAKennel();
            book.ShowDialog();
            this.Close();
        }

        private void mnuCancelReservation_Click(object sender, EventArgs e)
        {
            frmCancelReservation cancel = new frmCancelReservation();
            cancel.ShowDialog();
            this.Close();

        }
    }
}
