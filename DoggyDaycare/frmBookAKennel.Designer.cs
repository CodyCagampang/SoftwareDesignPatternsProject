namespace DoggyDaycare
{
    partial class frmBookAKennel
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
            components = new System.ComponentModel.Container();
            grdViewAvailableKennels = new DataGridView();
            lblSearchBySize = new Label();
            txtSearchKennelSize = new TextBox();
            mnuBackToDash = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            mnuDash = new ToolStripMenuItem();
            btnSearchKennel = new Button();
            grpReservation = new GroupBox();
            txtTotalCost = new TextBox();
            lblTotalCost = new Label();
            lblEndDate = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            txtDogWeight = new TextBox();
            txtDogBreed = new TextBox();
            txtDogName = new TextBox();
            lblStartDate = new Label();
            lblDogWeight = new Label();
            lblDogBreed = new Label();
            lblDogName = new Label();
            btnBookKennel = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtDogID = new TextBox();
            lblDogID = new Label();
            txtClientID = new TextBox();
            lblClientID = new Label();
            txtResID = new TextBox();
            lblResID = new Label();
            ((System.ComponentModel.ISupportInitialize)grdViewAvailableKennels).BeginInit();
            menuStrip1.SuspendLayout();
            grpReservation.SuspendLayout();
            SuspendLayout();
            // 
            // grdViewAvailableKennels
            // 
            grdViewAvailableKennels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViewAvailableKennels.Location = new Point(88, 88);
            grdViewAvailableKennels.Name = "grdViewAvailableKennels";
            grdViewAvailableKennels.RowHeadersWidth = 51;
            grdViewAvailableKennels.RowTemplate.Height = 29;
            grdViewAvailableKennels.Size = new Size(665, 147);
            grdViewAvailableKennels.TabIndex = 19;
            // 
            // lblSearchBySize
            // 
            lblSearchBySize.AutoSize = true;
            lblSearchBySize.Location = new Point(103, 54);
            lblSearchBySize.Name = "lblSearchBySize";
            lblSearchBySize.Size = new Size(191, 20);
            lblSearchBySize.TabIndex = 20;
            lblSearchBySize.Text = "Enter a Kennel Size (S, M, L)";
            // 
            // txtSearchKennelSize
            // 
            txtSearchKennelSize.Location = new Point(300, 50);
            txtSearchKennelSize.Name = "txtSearchKennelSize";
            txtSearchKennelSize.Size = new Size(139, 27);
            txtSearchKennelSize.TabIndex = 21;
            // 
            // mnuBackToDash
            // 
            mnuBackToDash.ImageScalingSize = new Size(20, 20);
            mnuBackToDash.Name = "mnuBackToDash";
            mnuBackToDash.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuDash });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuDash
            // 
            mnuDash.Name = "mnuDash";
            mnuDash.Size = new Size(151, 24);
            mnuDash.Text = "Back To Dashboard";
            mnuDash.Click += mnuDash_Click;
            // 
            // btnSearchKennel
            // 
            btnSearchKennel.Location = new Point(445, 50);
            btnSearchKennel.Name = "btnSearchKennel";
            btnSearchKennel.Size = new Size(153, 29);
            btnSearchKennel.TabIndex = 23;
            btnSearchKennel.Text = "Search For Kennel";
            btnSearchKennel.UseVisualStyleBackColor = true;
            btnSearchKennel.Click += btnSearchKennel_Click;
            // 
            // grpReservation
            // 
            grpReservation.Controls.Add(txtTotalCost);
            grpReservation.Controls.Add(lblTotalCost);
            grpReservation.Controls.Add(lblEndDate);
            grpReservation.Controls.Add(dtpCheckOut);
            grpReservation.Controls.Add(dtpCheckIn);
            grpReservation.Controls.Add(txtDogWeight);
            grpReservation.Controls.Add(txtDogBreed);
            grpReservation.Controls.Add(txtDogName);
            grpReservation.Controls.Add(lblStartDate);
            grpReservation.Controls.Add(lblDogWeight);
            grpReservation.Controls.Add(lblDogBreed);
            grpReservation.Controls.Add(lblDogName);
            grpReservation.Controls.Add(btnBookKennel);
            grpReservation.Controls.Add(txtPhoneNumber);
            grpReservation.Controls.Add(lblPhoneNumber);
            grpReservation.Controls.Add(txtEmail);
            grpReservation.Controls.Add(lblEmail);
            grpReservation.Controls.Add(txtLastName);
            grpReservation.Controls.Add(lblLastName);
            grpReservation.Controls.Add(txtFirstName);
            grpReservation.Controls.Add(lblFirstName);
            grpReservation.Location = new Point(55, 352);
            grpReservation.Name = "grpReservation";
            grpReservation.Size = new Size(751, 421);
            grpReservation.TabIndex = 24;
            grpReservation.TabStop = false;
            grpReservation.Text = "Reservation Details";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(285, 308);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(155, 27);
            txtTotalCost.TabIndex = 23;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(194, 311);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(75, 20);
            lblTotalCost.TabIndex = 22;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(358, 260);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(112, 20);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "Check Out Date";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(476, 255);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(155, 27);
            dtpCheckOut.TabIndex = 20;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(134, 255);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(155, 27);
            dtpCheckIn.TabIndex = 19;
            // 
            // txtDogWeight
            // 
            txtDogWeight.Location = new Point(549, 148);
            txtDogWeight.Name = "txtDogWeight";
            txtDogWeight.Size = new Size(155, 27);
            txtDogWeight.TabIndex = 18;
            // 
            // txtDogBreed
            // 
            txtDogBreed.Location = new Point(543, 99);
            txtDogBreed.Name = "txtDogBreed";
            txtDogBreed.Size = new Size(155, 27);
            txtDogBreed.TabIndex = 17;
            // 
            // txtDogName
            // 
            txtDogName.Location = new Point(543, 50);
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(155, 27);
            txtDogName.TabIndex = 16;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(19, 255);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 20);
            lblStartDate.TabIndex = 15;
            lblStartDate.Text = "Check In Date";
            // 
            // lblDogWeight
            // 
            lblDogWeight.AutoSize = true;
            lblDogWeight.Location = new Point(379, 148);
            lblDogWeight.Name = "lblDogWeight";
            lblDogWeight.Size = new Size(164, 20);
            lblDogWeight.TabIndex = 14;
            lblDogWeight.Text = "Enter The Dogs' Weight";
            // 
            // lblDogBreed
            // 
            lblDogBreed.AutoSize = true;
            lblDogBreed.Location = new Point(385, 99);
            lblDogBreed.Name = "lblDogBreed";
            lblDogBreed.Size = new Size(119, 20);
            lblDogBreed.TabIndex = 13;
            lblDogBreed.Text = "Enter Dog Breed";
            // 
            // lblDogName
            // 
            lblDogName.AutoSize = true;
            lblDogName.Location = new Point(390, 53);
            lblDogName.Name = "lblDogName";
            lblDogName.Size = new Size(120, 20);
            lblDogName.TabIndex = 12;
            lblDogName.Text = "Enter Dog Name";
            // 
            // btnBookKennel
            // 
            btnBookKennel.Location = new Point(257, 374);
            btnBookKennel.Name = "btnBookKennel";
            btnBookKennel.Size = new Size(192, 39);
            btnBookKennel.TabIndex = 11;
            btnBookKennel.Text = "Book The Kennel";
            btnBookKennel.UseVisualStyleBackColor = true;
            btnBookKennel.Click += btnBookKennel_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(134, 193);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(155, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(13, 196);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 148);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(134, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 27);
            txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(40, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(134, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 27);
            txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(40, 53);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // txtDogID
            // 
            txtDogID.Location = new Point(363, 302);
            txtDogID.Name = "txtDogID";
            txtDogID.Size = new Size(71, 27);
            txtDogID.TabIndex = 28;
            // 
            // lblDogID
            // 
            lblDogID.AutoSize = true;
            lblDogID.Location = new Point(300, 305);
            lblDogID.Name = "lblDogID";
            lblDogID.Size = new Size(57, 20);
            lblDogID.TabIndex = 27;
            lblDogID.Text = "Dog ID";
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(207, 302);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(62, 27);
            txtClientID.TabIndex = 26;
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Location = new Point(124, 302);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(66, 20);
            lblClientID.TabIndex = 25;
            lblClientID.Text = "Client ID";
            // 
            // txtResID
            // 
            txtResID.Location = new Point(571, 302);
            txtResID.Name = "txtResID";
            txtResID.Size = new Size(93, 27);
            txtResID.TabIndex = 30;
            // 
            // lblResID
            // 
            lblResID.AutoSize = true;
            lblResID.Location = new Point(460, 305);
            lblResID.Name = "lblResID";
            lblResID.Size = new Size(105, 20);
            lblResID.TabIndex = 29;
            lblResID.Text = "Reservation ID";
            // 
            // frmBookAKennel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 820);
            Controls.Add(txtResID);
            Controls.Add(lblResID);
            Controls.Add(txtDogID);
            Controls.Add(lblDogID);
            Controls.Add(txtClientID);
            Controls.Add(lblClientID);
            Controls.Add(grpReservation);
            Controls.Add(btnSearchKennel);
            Controls.Add(menuStrip1);
            Controls.Add(txtSearchKennelSize);
            Controls.Add(lblSearchBySize);
            Controls.Add(grdViewAvailableKennels);
            MainMenuStrip = menuStrip1;
            Name = "frmBookAKennel";
            Text = "Book A Kennel";
            Load += frmBookAKennel_Load;
            ((System.ComponentModel.ISupportInitialize)grdViewAvailableKennels).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpReservation.ResumeLayout(false);
            grpReservation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdViewAvailableKennels;
        private Label lblSearchBySize;
        private TextBox txtSearchKennelSize;
        private ContextMenuStrip mnuBackToDash;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDash;
        private Button btnSearchKennel;
        private GroupBox grpReservation;
        private Button btnBookKennel;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtDogWeight;
        private TextBox txtDogBreed;
        private TextBox txtDogName;
        private Label lblStartDate;
        private Label lblDogWeight;
        private Label lblDogBreed;
        private Label lblDogName;
        private DateTimePicker dtpCheckIn;
        private Label lblEndDate;
        private DateTimePicker dtpCheckOut;
        private Label lblTotalCost;
        private TextBox txtTotalCost;
        private TextBox txtDogID;
        private Label lblDogID;
        private TextBox txtClientID;
        private Label lblClientID;
        private TextBox txtResID;
        private Label lblResID;
    }
}