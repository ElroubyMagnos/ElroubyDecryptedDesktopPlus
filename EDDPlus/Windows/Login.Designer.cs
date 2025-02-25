namespace EDDPlus.Windows
{
    partial class Login
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
            PasswordEntry = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Enter = new Button();
            CreateAccount = new Button();
            SuspendLayout();
            // 
            // PasswordEntry
            // 
            PasswordEntry.Location = new Point(80, 56);
            PasswordEntry.Name = "PasswordEntry";
            PasswordEntry.Size = new Size(202, 23);
            PasswordEntry.TabIndex = 1;
            PasswordEntry.TextAlign = HorizontalAlignment.Center;
            PasswordEntry.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.Location = new Point(80, 12);
            Username.Name = "Username";
            Username.Size = new Size(202, 23);
            Username.TabIndex = 0;
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Enter
            // 
            Enter.Location = new Point(207, 98);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 2;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // CreateAccount
            // 
            CreateAccount.Location = new Point(14, 98);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(113, 23);
            CreateAccount.TabIndex = 3;
            CreateAccount.Text = "Create Account";
            CreateAccount.UseVisualStyleBackColor = true;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 136);
            Controls.Add(CreateAccount);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(PasswordEntry);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDD Plus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PasswordEntry;
        private TextBox Username;
        private Label label1;
        private Label label2;
        private Button Enter;
        private Button CreateAccount;
    }
}