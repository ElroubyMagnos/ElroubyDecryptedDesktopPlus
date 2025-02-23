namespace EDDPlus.Items
{
    partial class FileOf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // PicBox
            // 
            PicBox.BackgroundImage = Properties.Resources.file;
            PicBox.BackgroundImageLayout = ImageLayout.Stretch;
            PicBox.Location = new Point(3, 3);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(120, 82);
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            // 
            // NameOf
            // 
            NameOf.AutoSize = true;
            NameOf.Location = new Point(3, 88);
            NameOf.Name = "NameOf";
            NameOf.Size = new Size(57, 15);
            NameOf.TabIndex = 1;
            NameOf.Text = "NameOf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
