namespace DoggyDaycare
{
    partial class frmCancelReservation
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
            btnSearchResID = new Button();
            grdCancelReservation = new DataGridView();
            grpDeleteAReservation = new GroupBox();
            txtDogWeight = new TextBox();
            label1 = new Label();
            cboKennelTypes = new ComboBox();
            lblEndDate = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            txtDogBreed = new TextBox();
            txtDogName = new TextBox();
            lblStartDate = new Label();
            lblDogBreed = new Label();
            lblDogName = new Label();
            btnCancelAReservation = new Button();
            txtDailyRate = new TextBox();
            lblDailyRate = new Label();
            lblKennelType = new Label();
            txtKennelID = new TextBox();
            lblKennelID = new Label();
            menuStrip1 = new MenuStrip();
            mnuBackToDashboard = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdCancelReservation).BeginInit();
            grpDeleteAReservation.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchResID
            // 
            btnSearchResID.Location = new Point(369, 93);
            btnSearchResID.Name = "btnSearchResID";
            btnSearchResID.Size = new Size(184, 27);
            btnSearchResID.TabIndex = 0;
            btnSearchResID.Text = "Search Reservations";
            btnSearchResID.UseVisualStyleBackColor = true;
            btnSearchResID.Click += btnSearchResID_Click;
            // 
            // grdCancelReservation
            // 
            grdCancelReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCancelReservation.Location = new Point(210, 153);
            grdCancelReservation.Name = "grdCancelReservation";
            grdCancelReservation.RowHeadersWidth = 51;
            grdCancelReservation.RowTemplate.Height = 29;
            grdCancelReservation.Size = new Size(542, 116);
            grdCancelReservation.TabIndex = 1;
            grdCancelReservation.CellContentClick += grdCancelReservation_CellClick;
            // 
            // grpDeleteAReservation
            // 
            grpDeleteAReservation.Controls.Add(txtDogWeight);
            grpDeleteAReservation.Controls.Add(label1);
            grpDeleteAReservation.Controls.Add(cboKennelTypes);
            grpDeleteAReservation.Controls.Add(lblEndDate);
            grpDeleteAReservation.Controls.Add(dtpCheckOut);
            grpDeleteAReservation.Controls.Add(dtpCheckIn);
            grpDeleteAReservation.Controls.Add(txtDogBreed);
            grpDeleteAReservation.Controls.Add(txtDogName);
            grpDeleteAReservation.Controls.Add(lblStartDate);
            grpDeleteAReservation.Controls.Add(lblDogBreed);
            grpDeleteAReservation.Controls.Add(lblDogName);
            grpDeleteAReservation.Controls.Add(btnCancelAReservation);
            grpDeleteAReservation.Controls.Add(txtDailyRate);
            grpDeleteAReservation.Controls.Add(lblDailyRate);
            grpDeleteAReservation.Controls.Add(lblKennelType);
            grpDeleteAReservation.Controls.Add(txtKennelID);
            grpDeleteAReservation.Controls.Add(lblKennelID);
            grpDeleteAReservation.Location = new Point(95, 299);
            grpDeleteAReservation.Name = "grpDeleteAReservation";
            grpDeleteAReservation.Size = new Size(751, 421);
            grpDeleteAReservation.TabIndex = 25;
            grpDeleteAReservation.TabStop = false;
            grpDeleteAReservation.Text = "Delete A Reservation";
            // 
            // txtDogWeight
            // 
            txtDogWeight.Location = new Point(543, 152);
            txtDogWeight.Name = "txtDogWeight";
            txtDogWeight.Size = new Size(155, 27);
            txtDogWeight.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 155);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 23;
            label1.Text = "Dog Weight";
            // 
            // cboKennelTypes
            // 
            cboKennelTypes.FormattingEnabled = true;
            cboKennelTypes.Location = new Point(138, 96);
            cboKennelTypes.Name = "cboKennelTypes";
            cboKennelTypes.Size = new Size(151, 28);
            cboKennelTypes.TabIndex = 22;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(397, 212);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(112, 20);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "Check Out Date";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(543, 207);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(155, 27);
            dtpCheckOut.TabIndex = 20;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(134, 209);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(155, 27);
            dtpCheckIn.TabIndex = 19;
            // 
            // txtDogBreed
            // 
            txtDogBreed.Location = new Point(543, 103);
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
            lblStartDate.Location = new Point(20, 214);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 20);
            lblStartDate.TabIndex = 15;
            lblStartDate.Text = "Check In Date";
            // 
            // lblDogBreed
            // 
            lblDogBreed.AutoSize = true;
            lblDogBreed.Location = new Point(418, 106);
            lblDogBreed.Name = "lblDogBreed";
            lblDogBreed.Size = new Size(81, 20);
            lblDogBreed.TabIndex = 13;
            lblDogBreed.Text = "Dog Breed";
            // 
            // lblDogName
            // 
            lblDogName.AutoSize = true;
            lblDogName.Location = new Point(417, 57);
            lblDogName.Name = "lblDogName";
            lblDogName.Size = new Size(82, 20);
            lblDogName.TabIndex = 12;
            lblDogName.Text = "Dog Name";
            // 
            // btnCancelAReservation
            // 
            btnCancelAReservation.Location = new Point(252, 354);
            btnCancelAReservation.Name = "btnCancelAReservation";
            btnCancelAReservation.Size = new Size(192, 39);
            btnCancelAReservation.TabIndex = 11;
            btnCancelAReservation.Text = "Cancel Reservation";
            btnCancelAReservation.UseVisualStyleBackColor = true;
            btnCancelAReservation.Click += btnCancelReservation_Click;
            // 
            // txtDailyRate
            // 
            txtDailyRate.Location = new Point(134, 148);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(203, 27);
            txtDailyRate.TabIndex = 8;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(40, 148);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(77, 20);
            lblDailyRate.TabIndex = 7;
            lblDailyRate.Text = "Daily Rate";
            // 
            // lblKennelType
            // 
            lblKennelType.AutoSize = true;
            lblKennelType.Location = new Point(40, 99);
            lblKennelType.Name = "lblKennelType";
            lblKennelType.Size = new Size(89, 20);
            lblKennelType.TabIndex = 5;
            lblKennelType.Text = "Kennel Type";
            // 
            // txtKennelID
            // 
            txtKennelID.Location = new Point(134, 46);
            txtKennelID.Name = "txtKennelID";
            txtKennelID.Size = new Size(155, 27);
            txtKennelID.TabIndex = 4;
            // 
            // lblKennelID
            // 
            lblKennelID.AutoSize = true;
            lblKennelID.Location = new Point(40, 53);
            lblKennelID.Name = "lblKennelID";
            lblKennelID.Size = new Size(73, 20);
            lblKennelID.TabIndex = 3;
            lblKennelID.Text = "Kennel ID";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToDashboard });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToDashboard
            // 
            mnuBackToDashboard.Name = "mnuBackToDashboard";
            mnuBackToDashboard.Size = new Size(151, 24);
            mnuBackToDashboard.Text = "Back To Dashboard";
            mnuBackToDashboard.Click += mnuBackToDashboard_Click;
            // 
            // frmCancelReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 844);
            Controls.Add(grpDeleteAReservation);
            Controls.Add(grdCancelReservation);
            Controls.Add(btnSearchResID);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCancelReservation";
            Text = "Cancel A Reservation";
            ((System.ComponentModel.ISupportInitialize)grdCancelReservation).EndInit();
            grpDeleteAReservation.ResumeLayout(false);
            grpDeleteAReservation.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchResID;
        private DataGridView grdCancelReservation;
        private GroupBox grpDeleteAReservation;
        private TextBox txtTotalCost;
        private Label lblTotalCost;
        private Label lblEndDate;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private TextBox txtDogWeight;
        private TextBox txtDogBreed;
        private TextBox txtDogName;
        private Label lblStartDate;
        private Label lblDogWeight;
        private Label lblDogBreed;
        private Label lblDogName;
        private Button btnCancelAReservation;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtDailyRate;
        private Label lblDailyRate;
        private Label lblKennelType;
        private TextBox txtKennelID;
        private Label lblKennelID;
        private ComboBox cboKennelTypes;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToDashboard;
    }
}