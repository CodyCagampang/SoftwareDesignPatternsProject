namespace DoggyDaycare
{
    partial class frmAddKennel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            mnuBackToMainMenu = new ToolStripMenuItem();
            lblKennelID = new Label();
            txtKennelID = new TextBox();
            grpAddKennel = new GroupBox();
            cboCurrentStatus = new ComboBox();
            cboKennelCondition = new ComboBox();
            lblStatus = new Label();
            lblKennelCondition = new Label();
            txtKennelDescription = new TextBox();
            lblKennelDescription = new Label();
            btnAddKennel = new Button();
            txtDailyRate = new TextBox();
            lblDailyRate = new Label();
            cboKennelTypes = new ComboBox();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            grpAddKennel.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuBackToMainMenu });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 33);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnuBackToMainMenu
            // 
            mnuBackToMainMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            mnuBackToMainMenu.Name = "mnuBackToMainMenu";
            mnuBackToMainMenu.Size = new Size(179, 29);
            mnuBackToMainMenu.Text = "Back To Main Menu";
            mnuBackToMainMenu.Click += mnuBackToMainMenu_Click;
            // 
            // lblKennelID
            // 
            lblKennelID.AutoSize = true;
            lblKennelID.Location = new Point(21, 57);
            lblKennelID.Name = "lblKennelID";
            lblKennelID.Size = new Size(137, 20);
            lblKennelID.TabIndex = 3;
            lblKennelID.Text = "Assigned Kennel ID";
            // 
            // txtKennelID
            // 
            txtKennelID.Location = new Point(168, 54);
            txtKennelID.Name = "txtKennelID";
            txtKennelID.Size = new Size(76, 27);
            txtKennelID.TabIndex = 4;
            // 
            // grpAddKennel
            // 
            grpAddKennel.Controls.Add(cboCurrentStatus);
            grpAddKennel.Controls.Add(cboKennelCondition);
            grpAddKennel.Controls.Add(lblStatus);
            grpAddKennel.Controls.Add(lblKennelCondition);
            grpAddKennel.Controls.Add(txtKennelDescription);
            grpAddKennel.Controls.Add(lblKennelDescription);
            grpAddKennel.Controls.Add(btnAddKennel);
            grpAddKennel.Controls.Add(txtDailyRate);
            grpAddKennel.Controls.Add(lblDailyRate);
            grpAddKennel.Controls.Add(cboKennelTypes);
            grpAddKennel.Controls.Add(label1);
            grpAddKennel.Location = new Point(21, 108);
            grpAddKennel.Name = "grpAddKennel";
            grpAddKennel.Size = new Size(707, 341);
            grpAddKennel.TabIndex = 5;
            grpAddKennel.TabStop = false;
            grpAddKennel.Text = "Add Kennel Details";
            // 
            // cboCurrentStatus
            // 
            cboCurrentStatus.FormattingEnabled = true;
            cboCurrentStatus.Location = new Point(147, 234);
            cboCurrentStatus.Name = "cboCurrentStatus";
            cboCurrentStatus.Size = new Size(151, 28);
            cboCurrentStatus.TabIndex = 18;
            // 
            // cboKennelCondition
            // 
            cboKennelCondition.FormattingEnabled = true;
            cboKennelCondition.Location = new Point(147, 131);
            cboKennelCondition.Name = "cboKennelCondition";
            cboKennelCondition.Size = new Size(151, 28);
            cboKennelCondition.TabIndex = 17;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(22, 234);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Current Status";
            // 
            // lblKennelCondition
            // 
            lblKennelCondition.AutoSize = true;
            lblKennelCondition.Location = new Point(14, 134);
            lblKennelCondition.Name = "lblKennelCondition";
            lblKennelCondition.Size = new Size(123, 20);
            lblKennelCondition.TabIndex = 13;
            lblKennelCondition.Text = "Kennel Condition";
            // 
            // txtKennelDescription
            // 
            txtKennelDescription.Location = new Point(147, 84);
            txtKennelDescription.Name = "txtKennelDescription";
            txtKennelDescription.Size = new Size(175, 27);
            txtKennelDescription.TabIndex = 12;
            // 
            // lblKennelDescription
            // 
            lblKennelDescription.AutoSize = true;
            lblKennelDescription.Location = new Point(38, 87);
            lblKennelDescription.Name = "lblKennelDescription";
            lblKennelDescription.Size = new Size(85, 20);
            lblKennelDescription.TabIndex = 11;
            lblKennelDescription.Text = "Description";
            // 
            // btnAddKennel
            // 
            btnAddKennel.Location = new Point(267, 284);
            btnAddKennel.Name = "btnAddKennel";
            btnAddKennel.Size = new Size(205, 46);
            btnAddKennel.TabIndex = 10;
            btnAddKennel.Text = "Add Kennel";
            btnAddKennel.UseVisualStyleBackColor = true;
            btnAddKennel.Click += btnAddKennel_Click;
            // 
            // txtDailyRate
            // 
            txtDailyRate.Location = new Point(147, 182);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(175, 27);
            txtDailyRate.TabIndex = 7;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(14, 185);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(115, 20);
            lblDailyRate.TabIndex = 6;
            lblDailyRate.Text = "Enter Daily Rate";
            // 
            // cboKennelTypes
            // 
            cboKennelTypes.FormattingEnabled = true;
            cboKennelTypes.Items.AddRange(new object[] { "S", "M", "L" });
            cboKennelTypes.Location = new Point(147, 40);
            cboKennelTypes.Name = "cboKennelTypes";
            cboKennelTypes.Size = new Size(151, 28);
            cboKennelTypes.TabIndex = 5;
            //cboKennelTypes.SelectedIndexChanged += cboKennelTypes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter Kennel Type";
            // 
            // frmAddKennel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAddKennel);
            Controls.Add(txtKennelID);
            Controls.Add(lblKennelID);
            Controls.Add(menuStrip2);
            Name = "frmAddKennel";
            Text = "Add Kennel";
            Load += frmAddKennel_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            grpAddKennel.ResumeLayout(false);
            grpAddKennel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mnuBackToMainMenu;
        private Label lblKennelID;
        private TextBox txtKennelID;
        private GroupBox grpAddKennel;
        private TextBox txtDailyRate;
        private Label lblDailyRate;
        private ComboBox cboKennelTypes;
        private Label label1;
        private Button btnAddKennel;
        private Label lblKennelCondition;
        private TextBox txtKennelDescription;
        private Label lblKennelDescription;
        private Label lblStatus;
        private ComboBox cboKennelCondition;
        private ComboBox cboCurrentStatus;
    }
}
