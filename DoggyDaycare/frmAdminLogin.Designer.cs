namespace DoggyDaycare
{
    partial class frmAdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEnterAdminName = new Label();
            lblEnterPassword = new Label();
            grpAdminDetails = new GroupBox();
            btnAdminLogin = new Button();
            txtAdminPassword = new TextBox();
            txtAdminName = new TextBox();
            mnuBackToRegister = new MenuStrip();
            mnuRegsiter = new ToolStripMenuItem();
            grpAdminDetails.SuspendLayout();
            mnuBackToRegister.SuspendLayout();
            SuspendLayout();
            // 
            // lblEnterAdminName
            // 
            lblEnterAdminName.AutoSize = true;
            lblEnterAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterAdminName.Location = new Point(6, 62);
            lblEnterAdminName.Name = "lblEnterAdminName";
            lblEnterAdminName.Size = new Size(177, 28);
            lblEnterAdminName.TabIndex = 0;
            lblEnterAdminName.Text = "Enter Admin Name";
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterPassword.Location = new Point(6, 137);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(206, 28);
            lblEnterPassword.TabIndex = 2;
            lblEnterPassword.Text = "Enter Admin Password";
            // 
            // grpAdminDetails
            // 
            grpAdminDetails.Controls.Add(btnAdminLogin);
            grpAdminDetails.Controls.Add(txtAdminPassword);
            grpAdminDetails.Controls.Add(txtAdminName);
            grpAdminDetails.Controls.Add(lblEnterAdminName);
            grpAdminDetails.Controls.Add(lblEnterPassword);
            grpAdminDetails.Location = new Point(130, 117);
            grpAdminDetails.Name = "grpAdminDetails";
            grpAdminDetails.Size = new Size(675, 289);
            grpAdminDetails.TabIndex = 3;
            grpAdminDetails.TabStop = false;
            grpAdminDetails.Text = "Enter Admin Details";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(215, 208);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(189, 61);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Login As Admin";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(218, 137);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(131, 27);
            txtAdminPassword.TabIndex = 4;
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(201, 71);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(139, 27);
            txtAdminName.TabIndex = 3;
            // 
            // mnuBackToRegister
            // 
            mnuBackToRegister.ImageScalingSize = new Size(20, 20);
            mnuBackToRegister.Items.AddRange(new ToolStripItem[] { mnuRegsiter });
            mnuBackToRegister.Location = new Point(0, 0);
            mnuBackToRegister.Name = "mnuBackToRegister";
            mnuBackToRegister.Size = new Size(970, 28);
            mnuBackToRegister.TabIndex = 4;
            mnuBackToRegister.Text = "menuStrip1";
            // 
            // mnuRegsiter
            // 
            mnuRegsiter.Name = "mnuRegsiter";
            mnuRegsiter.Size = new Size(168, 24);
            mnuRegsiter.Text = "Back To Register Page";
            mnuRegsiter.Click += mnuRegsiter_Click;
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 515);
            Controls.Add(grpAdminDetails);
            Controls.Add(mnuBackToRegister);
            MainMenuStrip = mnuBackToRegister;
            Name = "frmAdminLogin";
            Text = "Admin Login";
            Load += frmAdminLogin_Load;
            grpAdminDetails.ResumeLayout(false);
            grpAdminDetails.PerformLayout();
            mnuBackToRegister.ResumeLayout(false);
            mnuBackToRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterAdminName;
        private Label lblEnterPassword;
        private GroupBox grpAdminDetails;
        private Button btnAdminLogin;
        private TextBox txtAdminPassword;
        private TextBox txtAdminName;
        private MenuStrip mnuBackToRegister;
        private ToolStripMenuItem mnuRegsiter;
    }
}