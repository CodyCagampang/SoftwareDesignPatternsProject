namespace DoggyDaycare
{
    partial class frmRegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterPage));
            btnRegisterClient = new Button();
            btnLoginAsAdmin = new Button();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            lblWelcomeMessage = new Label();
            lblRegisterAccount = new Label();
            lbllSammyQuote = new Label();
            btnLoginAsClient = new Button();
            SuspendLayout();
            // 
            // btnRegisterClient
            // 
            btnRegisterClient.Location = new Point(314, 323);
            btnRegisterClient.Name = "btnRegisterClient";
            btnRegisterClient.Size = new Size(174, 29);
            btnRegisterClient.TabIndex = 0;
            btnRegisterClient.Text = "Register As Client";
            btnRegisterClient.UseVisualStyleBackColor = true;
            btnRegisterClient.Click += btnRegisterClient_Click;
            // 
            // btnLoginAsAdmin
            // 
            btnLoginAsAdmin.Location = new Point(314, 423);
            btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            btnLoginAsAdmin.Size = new Size(174, 29);
            btnLoginAsAdmin.TabIndex = 1;
            btnLoginAsAdmin.Text = "Login As Admin";
            btnLoginAsAdmin.UseVisualStyleBackColor = true;
            btnLoginAsAdmin.Click += btnLoginAsAdmin_Click;
            // 
            // oracleCommand1
            // 
            oracleCommand1.RowsToFetchPerRoundTrip = 0L;
            oracleCommand1.Transaction = null;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(234, 61);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(386, 33);
            lblWelcomeMessage.TabIndex = 2;
            lblWelcomeMessage.Text = "Welcome To Our Doggy Daycare!";
            // 
            // lblRegisterAccount
            // 
            lblRegisterAccount.AutoSize = true;
            lblRegisterAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterAccount.Location = new Point(198, 265);
            lblRegisterAccount.Name = "lblRegisterAccount";
            lblRegisterAccount.Size = new Size(422, 31);
            lblRegisterAccount.TabIndex = 6;
            lblRegisterAccount.Text = "Please Register To Book A Kennel Today!";
            // 
            // lbllSammyQuote
            // 
            lbllSammyQuote.AutoSize = true;
            lbllSammyQuote.Font = new Font("Cambria Math", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbllSammyQuote.Location = new Point(279, 144);
            lbllSammyQuote.Name = "lbllSammyQuote";
            lbllSammyQuote.Size = new Size(270, 84);
            lbllSammyQuote.TabIndex = 5;
            lbllSammyQuote.Text = "\"You're In Great Paws!\" - Sammy";
            // 
            // btnLoginAsClient
            // 
            btnLoginAsClient.Location = new Point(314, 371);
            btnLoginAsClient.Name = "btnLoginAsClient";
            btnLoginAsClient.Size = new Size(174, 29);
            btnLoginAsClient.TabIndex = 7;
            btnLoginAsClient.Text = "Login as a Client";
            btnLoginAsClient.UseVisualStyleBackColor = true;
            btnLoginAsClient.Click += btnLoginAsClient_Click;
            // 
            // frmRegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 567);
            Controls.Add(btnLoginAsClient);
            Controls.Add(lblRegisterAccount);
            Controls.Add(lbllSammyQuote);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(btnLoginAsAdmin);
            Controls.Add(btnRegisterClient);
            Name = "frmRegisterPage";
            Text = "Register Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterClient;
        private Button btnLoginAsAdmin;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Label lblWelcomeMessage;
        private Label lblRegisterAccount;
        private Label lbllSammyQuote;
        private Button btnLoginAsClient;
    }
}