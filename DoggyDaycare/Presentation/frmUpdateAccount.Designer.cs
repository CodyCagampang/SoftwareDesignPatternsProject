namespace DoggyDaycare.Presentation
{
    partial class frmUpdateAccount
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
            txtFirstName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNum = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            menuStrip1 = new MenuStrip();
            mnuBackToMain = new ToolStripMenuItem();
            btnUpdateDetails = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(217, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(217, 153);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(185, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(217, 274);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(185, 27);
            txtPhoneNum.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(119, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(119, 160);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(119, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(118, 281);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToMain });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMain
            // 
            mnuBackToMain.Name = "mnuBackToMain";
            mnuBackToMain.Size = new Size(147, 24);
            mnuBackToMain.Text = "Back To Main Page";
            mnuBackToMain.Click += mnuBackToMain_Click;
            // 
            // btnUpdateDetails
            // 
            btnUpdateDetails.Location = new Point(316, 352);
            btnUpdateDetails.Name = "btnUpdateDetails";
            btnUpdateDetails.Size = new Size(142, 53);
            btnUpdateDetails.TabIndex = 9;
            btnUpdateDetails.Text = "Update Details";
            btnUpdateDetails.UseVisualStyleBackColor = true;
            btnUpdateDetails.Click += btnUpdateDetails_Click;
            // 
            // frmUpdateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateDetails);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtFirstName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUpdateAccount";
            Text = "frmUpdateAccount";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPhoneNum;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPassword;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToMain;
        private Button btnUpdateDetails;
    }
}