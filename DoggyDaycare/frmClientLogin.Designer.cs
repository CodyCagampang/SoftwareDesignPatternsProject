namespace DoggyDaycare
{
    partial class frmClientLogin
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
        /// 
        /// 
        /// 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegisterEmail = new Label();
            txtRegisterEmail = new TextBox();
            groupBox1 = new GroupBox();
            btnAccountLogin = new Button();
            txtEnterPassword = new TextBox();
            label1 = new Label();
            txtEnterEmail = new TextBox();
            menuStrip1 = new MenuStrip();
            mnuBackToRegisterDetails = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegisterEmail
            // 
            lblRegisterEmail.AutoSize = true;
            lblRegisterEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterEmail.Location = new Point(20, 65);
            lblRegisterEmail.Name = "lblRegisterEmail";
            lblRegisterEmail.Size = new Size(113, 28);
            lblRegisterEmail.TabIndex = 9;
            lblRegisterEmail.Text = "Enter Email:";
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(195, 135);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(152, 27);
            txtRegisterEmail.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAccountLogin);
            groupBox1.Controls.Add(txtEnterPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEnterEmail);
            groupBox1.Controls.Add(lblRegisterEmail);
            groupBox1.Location = new Point(73, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 300);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Login Details";
            // 
            // btnAccountLogin
            // 
            btnAccountLogin.Location = new Point(164, 210);
            btnAccountLogin.Name = "btnAccountLogin";
            btnAccountLogin.Size = new Size(214, 55);
            btnAccountLogin.TabIndex = 14;
            btnAccountLogin.Text = "Login";
            btnAccountLogin.UseVisualStyleBackColor = true;
            btnAccountLogin.Click += btnAccountLogin_Click;
            // 
            // txtEnterPassword
            // 
            txtEnterPassword.Location = new Point(173, 123);
            txtEnterPassword.Name = "txtEnterPassword";
            txtEnterPassword.Size = new Size(201, 27);
            txtEnterPassword.TabIndex = 12;
            txtEnterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 119);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 11;
            label1.Text = "Enter Password:";
            // 
            // txtEnterEmail
            // 
            txtEnterEmail.Location = new Point(152, 69);
            txtEnterEmail.Name = "txtEnterEmail";
            txtEnterEmail.Size = new Size(226, 27);
            txtEnterEmail.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToRegisterDetails });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToRegisterDetails
            // 
            mnuBackToRegisterDetails.Name = "mnuBackToRegisterDetails";
            mnuBackToRegisterDetails.Size = new Size(173, 24);
            mnuBackToRegisterDetails.Text = "Back To Register Menu";
            mnuBackToRegisterDetails.Click += mnuBackToRegisterDetails_Click;
            // 
            // frmClientLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(txtRegisterEmail);
            Name = "frmClientLogin";
            Text = "Account Login";
            Load += frmClientLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisterEmail;
        private TextBox txtRegisterEmail;
        private GroupBox groupBox1;
        private TextBox txtEnterPassword;
        private Label label1;
        private TextBox txtEnterEmail;
        private Button btnAccountLogin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToRegisterDetails;
    }
}