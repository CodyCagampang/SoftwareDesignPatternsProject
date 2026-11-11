namespace DoggyDaycare
{
    partial class frmDeleteKennel
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
            lblSearchKennelID = new Label();
            txtKennelID = new TextBox();
            btnSearchKennelID = new Button();
            grdDeleteKennel = new DataGridView();
            grpKennel = new GroupBox();
            cboCurrentStatus = new ComboBox();
            cboKennelCondition = new ComboBox();
            lblStatus = new Label();
            lblKennelCondition = new Label();
            txtKennelDescription = new TextBox();
            lblKennelDescription = new Label();
            btnDeleteKennel = new Button();
            txtDailyRate = new TextBox();
            lblDailyRate = new Label();
            cboKennelTypes = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuBackToMainMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdDeleteKennel).BeginInit();
            grpKennel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearchKennelID
            // 
            lblSearchKennelID.AutoSize = true;
            lblSearchKennelID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchKennelID.Location = new Point(245, 68);
            lblSearchKennelID.Name = "lblSearchKennelID";
            lblSearchKennelID.Size = new Size(133, 20);
            lblSearchKennelID.TabIndex = 2;
            lblSearchKennelID.Text = "Search a Kennel ID";
            // 
            // txtKennelID
            // 
            txtKennelID.Location = new Point(388, 65);
            txtKennelID.Name = "txtKennelID";
            txtKennelID.Size = new Size(71, 27);
            txtKennelID.TabIndex = 3;
            // 
            // btnSearchKennelID
            // 
            btnSearchKennelID.Location = new Point(465, 65);
            btnSearchKennelID.Name = "btnSearchKennelID";
            btnSearchKennelID.Size = new Size(154, 29);
            btnSearchKennelID.TabIndex = 4;
            btnSearchKennelID.Text = "Search For Kennel";
            btnSearchKennelID.UseVisualStyleBackColor = true;
            btnSearchKennelID.Click += btnSearchKennelID_Click;
            // 
            // grdDeleteKennel
            // 
            grdDeleteKennel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDeleteKennel.Location = new Point(47, 118);
            grdDeleteKennel.Name = "grdDeleteKennel";
            grdDeleteKennel.RowHeadersWidth = 51;
            grdDeleteKennel.Size = new Size(798, 188);
            grdDeleteKennel.TabIndex = 5;
            grdDeleteKennel.CellClick += grdDeleteKennel_CellClick;
            // 
            // grpKennel
            // 
            grpKennel.Controls.Add(cboCurrentStatus);
            grpKennel.Controls.Add(cboKennelCondition);
            grpKennel.Controls.Add(lblStatus);
            grpKennel.Controls.Add(lblKennelCondition);
            grpKennel.Controls.Add(txtKennelDescription);
            grpKennel.Controls.Add(lblKennelDescription);
            grpKennel.Controls.Add(btnDeleteKennel);
            grpKennel.Controls.Add(txtDailyRate);
            grpKennel.Controls.Add(lblDailyRate);
            grpKennel.Controls.Add(cboKennelTypes);
            grpKennel.Controls.Add(label1);
            grpKennel.Location = new Point(47, 324);
            grpKennel.Name = "grpKennel";
            grpKennel.Size = new Size(798, 316);
            grpKennel.TabIndex = 7;
            grpKennel.TabStop = false;
            grpKennel.Text = "Delete Kennel";
            // 
            // cboCurrentStatus
            // 
            cboCurrentStatus.FormattingEnabled = true;
            cboCurrentStatus.Location = new Point(198, 216);
            cboCurrentStatus.Name = "cboCurrentStatus";
            cboCurrentStatus.Size = new Size(151, 28);
            cboCurrentStatus.TabIndex = 18;
            // 
            // cboKennelCondition
            // 
            cboKennelCondition.FormattingEnabled = true;
            cboKennelCondition.Location = new Point(198, 117);
            cboKennelCondition.Name = "cboKennelCondition";
            cboKennelCondition.Size = new Size(151, 28);
            cboKennelCondition.TabIndex = 17;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(62, 219);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Current Status";
            // 
            // lblKennelCondition
            // 
            lblKennelCondition.AutoSize = true;
            lblKennelCondition.Location = new Point(62, 117);
            lblKennelCondition.Name = "lblKennelCondition";
            lblKennelCondition.Size = new Size(123, 20);
            lblKennelCondition.TabIndex = 13;
            lblKennelCondition.Text = "Kennel Condition";
            // 
            // txtKennelDescription
            // 
            txtKennelDescription.Location = new Point(198, 74);
            txtKennelDescription.Name = "txtKennelDescription";
            txtKennelDescription.Size = new Size(594, 27);
            txtKennelDescription.TabIndex = 12;
            // 
            // lblKennelDescription
            // 
            lblKennelDescription.AutoSize = true;
            lblKennelDescription.Location = new Point(62, 74);
            lblKennelDescription.Name = "lblKennelDescription";
            lblKennelDescription.Size = new Size(85, 20);
            lblKennelDescription.TabIndex = 11;
            lblKennelDescription.Text = "Description";
            // 
            // btnDeleteKennel
            // 
            btnDeleteKennel.Location = new Point(325, 263);
            btnDeleteKennel.Name = "btnDeleteKennel";
            btnDeleteKennel.Size = new Size(163, 32);
            btnDeleteKennel.TabIndex = 10;
            btnDeleteKennel.Text = "Delete Kennel";
            btnDeleteKennel.UseVisualStyleBackColor = true;
            btnDeleteKennel.Click += btnDeleteKennel_Click;
            // 
            // txtDailyRate
            // 
            txtDailyRate.Location = new Point(198, 165);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(68, 27);
            txtDailyRate.TabIndex = 7;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(62, 168);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(77, 20);
            lblDailyRate.TabIndex = 6;
            lblDailyRate.Text = "Daily Rate";
            // 
            // cboKennelTypes
            // 
            cboKennelTypes.FormattingEnabled = true;
            cboKennelTypes.Location = new Point(198, 26);
            cboKennelTypes.Name = "cboKennelTypes";
            cboKennelTypes.Size = new Size(151, 28);
            cboKennelTypes.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "Kennel Type";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToMainMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(918, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMainMenu
            // 
            mnuBackToMainMenu.Name = "mnuBackToMainMenu";
            mnuBackToMainMenu.Size = new Size(152, 24);
            mnuBackToMainMenu.Text = "Back To Main Menu";
            mnuBackToMainMenu.Click += mnuBackToMainMenu_Click;
            // 
            // frmDeleteKennel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 667);
            Controls.Add(grpKennel);
            Controls.Add(grdDeleteKennel);
            Controls.Add(btnSearchKennelID);
            Controls.Add(txtKennelID);
            Controls.Add(lblSearchKennelID);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDeleteKennel";
            Text = "frmDeleteKennel";
            Load += frmDeleteKennel_Load;
            ((System.ComponentModel.ISupportInitialize)grdDeleteKennel).EndInit();
            grpKennel.ResumeLayout(false);
            grpKennel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchKennelID;
        private TextBox txtKennelID;
        private Button btnSearchKennelID;
        private DataGridView grdDeleteKennel;
        private GroupBox grpKennel;
        private ComboBox cboCurrentStatus;
        private ComboBox cboKennelCondition;
        private Label lblStatus;
        private Label lblKennelCondition;
        private TextBox txtKennelDescription;
        private Label lblKennelDescription;
        private Button btnDeleteKennel;
        private TextBox txtDailyRate;
        private Label lblDailyRate;
        private ComboBox cboKennelTypes;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToMainMenu;
    }
}