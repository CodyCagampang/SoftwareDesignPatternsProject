namespace DoggyDaycare
{
    partial class frmClientRegister
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
            btnRegisterClient = new Button();
            menuStrip1 = new MenuStrip();
            mnuBackToRegisterPage = new ToolStripMenuItem();
            lblRegisterMessage = new Label();
            btnAccountLogin = new Button();
            txtClientID = new TextBox();
            lblClientID = new Label();
            grpRegisterClient = new GroupBox();
            txtFirstName = new TextBox();
            txtPhoneNum = new TextBox();
            lblFirstName = new Label();
            lblEmail = new Label();
            txtSurname = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblSurname = new Label();
            menuStrip1.SuspendLayout();
            grpRegisterClient.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterClient
            // 
            btnRegisterClient.Location = new Point(249, 383);
            btnRegisterClient.Name = "btnRegisterClient";
            btnRegisterClient.Size = new Size(214, 55);
            btnRegisterClient.TabIndex = 10;
            btnRegisterClient.Text = "Register";
            btnRegisterClient.UseVisualStyleBackColor = true;
            btnRegisterClient.Click += btnRegisterClient_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToRegisterPage });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToRegisterPage
            // 
            mnuBackToRegisterPage.Name = "mnuBackToRegisterPage";
            mnuBackToRegisterPage.Size = new Size(168, 24);
            mnuBackToRegisterPage.Text = "Back To Register Page";
            mnuBackToRegisterPage.Click += mnuBackToRegisterPage_Click;
            // 
            // lblRegisterMessage
            // 
            lblRegisterMessage.AutoSize = true;
            lblRegisterMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterMessage.Location = new Point(168, 40);
            lblRegisterMessage.Name = "lblRegisterMessage";
            lblRegisterMessage.Size = new Size(430, 38);
            lblRegisterMessage.TabIndex = 12;
            lblRegisterMessage.Text = "Register To Book A Kennel Today!";
            // 
            // btnAccountLogin
            // 
            btnAccountLogin.Location = new Point(249, 444);
            btnAccountLogin.Name = "btnAccountLogin";
            btnAccountLogin.Size = new Size(214, 55);
            btnAccountLogin.TabIndex = 13;
            btnAccountLogin.Text = "Proceed To Login";
            btnAccountLogin.UseVisualStyleBackColor = true;
            btnAccountLogin.Click += btnAccountLogin_Click;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(197, 98);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(124, 27);
            txtClientID.TabIndex = 15;
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientID.Location = new Point(125, 101);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(66, 20);
            lblClientID.TabIndex = 16;
            lblClientID.Text = "Client ID";
            // 
            // grpRegisterClient
            // 
            grpRegisterClient.Controls.Add(txtFirstName);
            grpRegisterClient.Controls.Add(txtPhoneNum);
            grpRegisterClient.Controls.Add(lblFirstName);
            grpRegisterClient.Controls.Add(lblEmail);
            grpRegisterClient.Controls.Add(txtSurname);
            grpRegisterClient.Controls.Add(lblPhoneNumber);
            grpRegisterClient.Controls.Add(txtEmail);
            grpRegisterClient.Controls.Add(lblPassword);
            grpRegisterClient.Controls.Add(txtPassword);
            grpRegisterClient.Controls.Add(lblSurname);
            grpRegisterClient.Location = new Point(95, 136);
            grpRegisterClient.Name = "grpRegisterClient";
            grpRegisterClient.Size = new Size(586, 241);
            grpRegisterClient.TabIndex = 17;
            grpRegisterClient.TabStop = false;
            grpRegisterClient.Text = "Register Here!";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(200, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(159, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(200, 198);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(159, 27);
            txtPhoneNum.TabIndex = 13;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(46, 22);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 28);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(46, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(200, 67);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(159, 27);
            txtSurname.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(46, 194);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(144, 28);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 27);
            txtEmail.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(46, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 27);
            txtPassword.TabIndex = 10;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.Location = new Point(46, 63);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(89, 28);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Surname";
            // 
            // frmClientRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(grpRegisterClient);
            Controls.Add(lblClientID);
            Controls.Add(txtClientID);
            Controls.Add(btnAccountLogin);
            Controls.Add(lblRegisterMessage);
            Controls.Add(btnRegisterClient);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmClientRegister";
            Text = "Register Account";
            Load += frmClientRegister_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpRegisterClient.ResumeLayout(false);
            grpRegisterClient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegisterClient;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToRegisterPage;
        private Label lblRegisterMessage;
        private Button btnAccountLogin;
        private TextBox txtClientID;
        private Label lblClientID;
        private GroupBox grpRegisterClient;
        private TextBox txtFirstName;
        private TextBox txtPhoneNum;
        private Label lblFirstName;
        private Label lblEmail;
        private TextBox txtSurname;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblSurname;
    }
}