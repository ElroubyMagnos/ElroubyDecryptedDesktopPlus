namespace EDDPlus.Windows
{
    partial class PropertiesWindow
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
            label1 = new Label();
            label2 = new Label();
            NameOfItem = new TextBox();
            FullPathOf = new TextBox();
            SizeOf = new TextBox();
            label3 = new Label();
            PathInSpace = new TextBox();
            label4 = new Label();
            IconBox = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)IconBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "FullName: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Full Path:";
            // 
            // NameOfItem
            // 
            NameOfItem.Location = new Point(82, 13);
            NameOfItem.Name = "NameOfItem";
            NameOfItem.ReadOnly = true;
            NameOfItem.Size = new Size(210, 23);
            NameOfItem.TabIndex = 3;
            // 
            // FullPathOf
            // 
            FullPathOf.Location = new Point(82, 46);
            FullPathOf.Name = "FullPathOf";
            FullPathOf.ReadOnly = true;
            FullPathOf.Size = new Size(210, 23);
            FullPathOf.TabIndex = 4;
            // 
            // SizeOf
            // 
            SizeOf.Location = new Point(82, 77);
            SizeOf.Name = "SizeOf";
            SizeOf.ReadOnly = true;
            SizeOf.Size = new Size(210, 23);
            SizeOf.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Size (Bytes):";
            // 
            // PathInSpace
            // 
            PathInSpace.Location = new Point(82, 106);
            PathInSpace.Name = "PathInSpace";
            PathInSpace.ReadOnly = true;
            PathInSpace.Size = new Size(210, 23);
            PathInSpace.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Path:";
            // 
            // IconBox
            // 
            IconBox.BackgroundImageLayout = ImageLayout.Stretch;
            IconBox.Location = new Point(82, 138);
            IconBox.Name = "IconBox";
            IconBox.Size = new Size(210, 132);
            IconBox.TabIndex = 9;
            IconBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Icon:";
            // 
            // PropertiesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 289);
            Controls.Add(label5);
            Controls.Add(IconBox);
            Controls.Add(PathInSpace);
            Controls.Add(label4);
            Controls.Add(SizeOf);
            Controls.Add(label3);
            Controls.Add(FullPathOf);
            Controls.Add(NameOfItem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PropertiesWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Properties: ";
            ((System.ComponentModel.ISupportInitialize)IconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameOfItem;
        private TextBox FullPathOf;
        private TextBox SizeOf;
        private Label label3;
        private TextBox PathInSpace;
        private Label label4;
        private PictureBox IconBox;
        private Label label5;
    }
}