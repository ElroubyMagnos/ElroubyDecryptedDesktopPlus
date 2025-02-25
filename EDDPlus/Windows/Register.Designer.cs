namespace EDDPlus.Windows
{
    partial class Register
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
            label2 = new Label();
            label1 = new Label();
            Username = new TextBox();
            PasswordEntry = new TextBox();
            label3 = new Label();
            ConfirmPass = new TextBox();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 65);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 6;
            label1.Text = "User Name:";
            // 
            // Username
            // 
            Username.Location = new Point(125, 18);
            Username.Name = "Username";
            Username.Size = new Size(202, 23);
            Username.TabIndex = 0;
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordEntry
            // 
            PasswordEntry.Location = new Point(125, 62);
            PasswordEntry.Name = "PasswordEntry";
            PasswordEntry.Size = new Size(202, 23);
            PasswordEntry.TabIndex = 1;
            PasswordEntry.TextAlign = HorizontalAlignment.Center;
            PasswordEntry.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 9;
            label3.Text = "Confirm Password:";
            // 
            // ConfirmPass
            // 
            ConfirmPass.Location = new Point(125, 95);
            ConfirmPass.Name = "ConfirmPass";
            ConfirmPass.Size = new Size(202, 23);
            ConfirmPass.TabIndex = 2;
            ConfirmPass.TextAlign = HorizontalAlignment.Center;
            ConfirmPass.UseSystemPasswordChar = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(252, 141);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 23);
            RegisterBtn.TabIndex = 3;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 176);
            Controls.Add(RegisterBtn);
            Controls.Add(label3);
            Controls.Add(ConfirmPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(PasswordEntry);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox Username;
        private TextBox PasswordEntry;
        private Label label3;
        private TextBox ConfirmPass;
        private Button RegisterBtn;
    }
}