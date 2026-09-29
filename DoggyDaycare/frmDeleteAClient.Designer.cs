namespace DoggyDaycare
{
    partial class frmDeleteAClient
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
            grdClients = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuBackToMainMenu = new ToolStripMenuItem();
            lblSearchClientID = new Label();
            txtSearchClientID = new TextBox();
            btnSearchKClientID = new Button();
            grpClientDetails = new GroupBox();
            btnRemoveAClient = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            ((System.ComponentModel.ISupportInitialize)grdClients).BeginInit();
            menuStrip1.SuspendLayout();
            grpClientDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grdClients
            // 
            grdClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClients.Location = new Point(153, 139);
            grdClients.Name = "grdClients";
            grdClients.RowHeadersWidth = 51;
            grdClients.RowTemplate.Height = 29;
            grdClients.Size = new Size(751, 135);
            grdClients.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToMainMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1109, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMainMenu
            // 
            mnuBackToMainMenu.Name = "mnuBackToMainMenu";
            mnuBackToMainMenu.Size = new Size(152, 24);
            mnuBackToMainMenu.Text = "Back To Main Menu";

            // 
            // lblSearchClientID
            // 
            lblSearchClientID.AutoSize = true;
            lblSearchClientID.Location = new Point(264, 86);
            lblSearchClientID.Name = "lblSearchClientID";
            lblSearchClientID.Size = new Size(114, 20);
            lblSearchClientID.TabIndex = 2;
            lblSearchClientID.Text = "Search Client ID";
            // 
            // txtSearchClientID
            // 
            txtSearchClientID.Location = new Point(396, 83);
            txtSearchClientID.Name = "txtSearchClientID";
            txtSearchClientID.Size = new Size(153, 27);
            txtSearchClientID.TabIndex = 3;
            // 
            // btnSearchKClientID
            // 
            btnSearchKClientID.Location = new Point(566, 75);
            btnSearchKClientID.Name = "btnSearchKClientID";
            btnSearchKClientID.Size = new Size(182, 43);
            btnSearchKClientID.TabIndex = 4;
            btnSearchKClientID.Text = "Search Client ID";
            btnSearchKClientID.UseVisualStyleBackColor = true;
            btnSearchKClientID.Click += btnSearchKClientID_Click;
            // 
            // grpClientDetails
            // 
            grpClientDetails.Controls.Add(btnRemoveAClient);
            grpClientDetails.Controls.Add(txtPhoneNumber);
            grpClientDetails.Controls.Add(lblPhoneNumber);
            grpClientDetails.Controls.Add(txtEmail);
            grpClientDetails.Controls.Add(lblEmail);
            grpClientDetails.Controls.Add(txtLastName);
            grpClientDetails.Controls.Add(lblLastName);
            grpClientDetails.Controls.Add(txtFirstName);
            grpClientDetails.Controls.Add(lblFirstName);
            grpClientDetails.Location = new Point(153, 297);
            grpClientDetails.Name = "grpClientDetails";
            grpClientDetails.Size = new Size(751, 325);
            grpClientDetails.TabIndex = 5;
            grpClientDetails.TabStop = false;
            grpClientDetails.Text = "Client Details";
            // 
            // btnRemoveAClient
            // 
            btnRemoveAClient.Location = new Point(259, 253);
            btnRemoveAClient.Name = "btnRemoveAClient";
            btnRemoveAClient.Size = new Size(192, 39);
            btnRemoveAClient.TabIndex = 11;
            btnRemoveAClient.Text = "Remove This Client";
            btnRemoveAClient.UseVisualStyleBackColor = true;
            btnRemoveAClient.Click += btnRemoveAClient_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(127, 197);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(155, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(6, 197);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(33, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(127, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 27);
            txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(32, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(127, 40);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 27);
            txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(32, 43);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // frmDeleteAClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 686);
            Controls.Add(grpClientDetails);
            Controls.Add(btnSearchKClientID);
            Controls.Add(txtSearchClientID);
            Controls.Add(lblSearchClientID);
            Controls.Add(grdClients);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDeleteAClient";
            Text = "Delete A Client";
            Load += frmListClients_Load;
            ((System.ComponentModel.ISupportInitialize)grdClients).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpClientDetails.ResumeLayout(false);
            grpClientDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdClients;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToMainMenu;
        private Label lblSearchClientID;
        private TextBox txtSearchClientID;
        private Button btnSearchKClientID;
        private GroupBox grpClientDetails;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnRemoveAClient;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
    }
}