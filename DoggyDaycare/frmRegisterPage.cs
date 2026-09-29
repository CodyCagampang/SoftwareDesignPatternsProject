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
    public partial class frmRegisterPage : Form
    {
        public frmRegisterPage()
        {
            InitializeComponent();
        }



        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            frmClientRegister frmRegister = new frmClientRegister();
            this.Hide();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin frmAdmin = new frmAdminLogin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Close();
        }

        private void btnLoginAsClient_Click(object sender, EventArgs e)
        {
            frmClientLogin frmLogin = new frmClientLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
