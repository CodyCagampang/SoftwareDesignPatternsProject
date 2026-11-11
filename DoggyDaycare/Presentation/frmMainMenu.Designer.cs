namespace DoggyDaycare
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuKennel = new ToolStripMenuItem();
            mnuAddKennel = new ToolStripMenuItem();
            mnuRemoveKennel = new ToolStripMenuItem();
            mnuUpdateKennel = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            mnuDeRegisterClient = new ToolStripMenuItem();
            mnuListAllClients = new ToolStripMenuItem();
            mnuBookAKennel = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(225, 28);
            label1.Name = "label1";
            label1.Size = new Size(337, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Our Daycare!";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuKennel, clientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(813, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuKennel
            // 
            mnuKennel.DropDownItems.AddRange(new ToolStripItem[] { mnuAddKennel, mnuRemoveKennel, mnuUpdateKennel, mnuBookAKennel });
            mnuKennel.Name = "mnuKennel";
            mnuKennel.Size = new Size(74, 24);
            mnuKennel.Text = "Kennels";
            // 
            // mnuAddKennel
            // 
            mnuAddKennel.Name = "mnuAddKennel";
            mnuAddKennel.Size = new Size(224, 26);
            mnuAddKennel.Text = "Add Kennel";
            mnuAddKennel.Click += mnuAddKennel_Click;
            // 
            // mnuRemoveKennel
            // 
            mnuRemoveKennel.Name = "mnuRemoveKennel";
            mnuRemoveKennel.Size = new Size(224, 26);
            mnuRemoveKennel.Text = "Remove Kennel";
            mnuRemoveKennel.Click += mnuRemoveKennel_Click;
            // 
            // mnuUpdateKennel
            // 
            mnuUpdateKennel.Name = "mnuUpdateKennel";
            mnuUpdateKennel.Size = new Size(224, 26);
            mnuUpdateKennel.Text = "Update Kennel";
            mnuUpdateKennel.Click += mnuUpdateKennel_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDeRegisterClient, mnuListAllClients });
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(67, 24);
            clientsToolStripMenuItem.Text = "Clients";
            // 
            // mnuDeRegisterClient
            // 
            mnuDeRegisterClient.Name = "mnuDeRegisterClient";
            mnuDeRegisterClient.Size = new Size(213, 26);
            mnuDeRegisterClient.Text = "De-Register Client";
            mnuDeRegisterClient.Click += mnuDeRegisterClient_Click;
            // 
            // mnuListAllClients
            // 
            mnuListAllClients.Name = "mnuListAllClients";
            mnuListAllClients.Size = new Size(213, 26);
            mnuListAllClients.Text = "List All Clients";
            mnuListAllClients.Click += mnuListAllClients_Click;
            // 
            // mnuBookAKennel
            // 
            mnuBookAKennel.Name = "mnuBookAKennel";
            mnuBookAKennel.Size = new Size(224, 26);
            mnuBookAKennel.Text = "Book A Kennel";
            mnuBookAKennel.Click += this.mnuBookAKennel_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(813, 463);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainMenu";
            Text = "Main Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuKennel;
        private ToolStripMenuItem mnuAddKennel;
        private ToolStripMenuItem mnuRemoveKennel;
        private ToolStripMenuItem mnuUpdateKennel;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem mnuDeRegisterClient;
        private ToolStripMenuItem mnuListAllClients;
        private ToolStripMenuItem mnuBookAKennel;
    }
}
