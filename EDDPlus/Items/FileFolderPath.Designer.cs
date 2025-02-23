namespace EDDPlus.Items
{
    partial class FileFolderPath
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
            components = new System.ComponentModel.Container();
            PicBox = new PictureBox();
            MenuStrip = new ContextMenuStrip(components);
            Cut_MenuStrip = new ToolStripMenuItem();
            Copy_MenuStrip = new ToolStripMenuItem();
            Delete_MenuStrip = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            PropertiesOf = new ToolStripMenuItem();
            NameOf = new Label();
            Tip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // PicBox
            // 
            PicBox.BackgroundImage = Properties.Resources.file;
            PicBox.BackgroundImageLayout = ImageLayout.Stretch;
            PicBox.ContextMenuStrip = MenuStrip;
            PicBox.Location = new Point(3, 3);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(120, 82);
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox.TabIndex = 2;
            PicBox.TabStop = false;
            PicBox.Click += PicBox_Click;
            PicBox.DoubleClick += NameOf_DoubleClick;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { Cut_MenuStrip, Copy_MenuStrip, Delete_MenuStrip, toolStripSeparator1, PropertiesOf });
            MenuStrip.Name = "contextMenuStrip1";
            MenuStrip.Size = new Size(128, 98);
            MenuStrip.Opening += MenuStrip_Opening;
            // 
            // Cut_MenuStrip
            // 
            Cut_MenuStrip.Name = "Cut_MenuStrip";
            Cut_MenuStrip.Size = new Size(127, 22);
            Cut_MenuStrip.Text = "Cut";
            Cut_MenuStrip.Click += Cut_MenuStrip_Click;
            // 
            // Copy_MenuStrip
            // 
            Copy_MenuStrip.Name = "Copy_MenuStrip";
            Copy_MenuStrip.Size = new Size(127, 22);
            Copy_MenuStrip.Text = "Copy";
            Copy_MenuStrip.Click += Copy_MenuStrip_Click;
            // 
            // Delete_MenuStrip
            // 
            Delete_MenuStrip.Name = "Delete_MenuStrip";
            Delete_MenuStrip.Size = new Size(127, 22);
            Delete_MenuStrip.Text = "Delete";
            Delete_MenuStrip.Click += Delete_MenuStrip_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(124, 6);
            // 
            // PropertiesOf
            // 
            PropertiesOf.Name = "PropertiesOf";
            PropertiesOf.Size = new Size(127, 22);
            PropertiesOf.Text = "Properties";
            PropertiesOf.Click += PropertiesOf_Click;
            // 
            // NameOf
            // 
            NameOf.AutoSize = true;
            NameOf.ContextMenuStrip = MenuStrip;
            NameOf.Location = new Point(3, 88);
            NameOf.Name = "NameOf";
            NameOf.Size = new Size(52, 15);
            NameOf.TabIndex = 3;
            NameOf.Text = "NameOf";
            NameOf.Click += PicBox_Click;
            NameOf.DoubleClick += NameOf_DoubleClick;
            // 
            // Tip
            // 
            Tip.AutoPopDelay = 10000;
            Tip.InitialDelay = 500;
            Tip.IsBalloon = true;
            Tip.ReshowDelay = 100;
            // 
            // FileFolderPath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = MenuStrip;
            Controls.Add(NameOf);
            Controls.Add(PicBox);
            Name = "FileFolderPath";
            Size = new Size(126, 111);
            Load += FileFolderPath_Load;
            Click += PicBox_Click;
            DoubleClick += NameOf_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            MenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox PicBox;
        public Label NameOf;
        private ToolTip Tip;
        private ContextMenuStrip MenuStrip;
        private ToolStripMenuItem Cut_MenuStrip;
        private ToolStripMenuItem Copy_MenuStrip;
        private ToolStripMenuItem Delete_MenuStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem PropertiesOf;
    }
}
