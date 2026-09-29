namespace DoggyDaycare
{
    partial class frmListAllClients
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
            grdViewClients = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuBackToMainMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdViewClients).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdViewClients
            // 
            grdViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViewClients.Location = new Point(106, 145);
            grdViewClients.Name = "grdViewClients";
            grdViewClients.RowHeadersWidth = 51;
            grdViewClients.RowTemplate.Height = 29;
            grdViewClients.Size = new Size(600, 188);
            grdViewClients.TabIndex = 0;
            grdViewClients.CellContentClick += grdViewClients_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBackToMainMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMainMenu
            // 
            mnuBackToMainMenu.Name = "mnuBackToMainMenu";
            mnuBackToMainMenu.Size = new Size(152, 24);
            mnuBackToMainMenu.Text = "Back To Main Menu";
            mnuBackToMainMenu.Click += mnuBackToMainMenu_Click;
            // 
            // frmListAllClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdViewClients);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmListAllClients";
            Text = "List All Clients";
            ((System.ComponentModel.ISupportInitialize)grdViewClients).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            this.Load += frmListAllClients_Load;

        }

        #endregion

        private DataGridView grdViewClients;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuBackToMainMenu;
    }
}