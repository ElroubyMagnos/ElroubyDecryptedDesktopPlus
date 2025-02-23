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
            UserPic = new PictureBox();
            PasswordEntry = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Enter = new Button();
            ((System.ComponentModel.ISupportInitialize)UserPic).BeginInit();
            SuspendLayout();
            // 
            // UserPic
            // 
            UserPic.BackgroundImageLayout = ImageLayout.Stretch;
            UserPic.Location = new Point(91, 12);
            UserPic.Name = "UserPic";
            UserPic.Size = new Size(136, 105);
            UserPic.TabIndex = 0;
            UserPic.TabStop = false;
            // 
            // PasswordEntry
            // 
            PasswordEntry.Location = new Point(83, 167);
            PasswordEntry.Name = "PasswordEntry";
            PasswordEntry.Size = new Size(202, 23);
            PasswordEntry.TabIndex = 0;
            PasswordEntry.TextAlign = HorizontalAlignment.Center;
            // 
            // Username
            // 
            Username.Location = new Point(83, 123);
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Size = new Size(202, 23);
            Username.TabIndex = 1;
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 170);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Enter
            // 
            Enter.Location = new Point(210, 215);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 4;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 250);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(PasswordEntry);
            Controls.Add(UserPic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDD Plus";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)UserPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox UserPic;
        private TextBox PasswordEntry;
        private TextBox Username;
        private Label label1;
        private Label label2;
        private Button Enter;
    }
}