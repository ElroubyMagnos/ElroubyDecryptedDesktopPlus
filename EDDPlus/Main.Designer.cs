
namespace EDDPlus
{
    partial class Main
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
            SpaceOfFiles = new FlowLayoutPanel();
            OpenFileDialog = new OpenFileDialog();
            MenuStrip = new MenuStrip();
            BackButton = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            ImportFile = new ToolStripMenuItem();
            ImportFolder = new ToolStripMenuItem();
            ExportSelected = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            ProgressBar = new ProgressBar();
            FolderDialog = new FolderBrowserDialog();
            PathOf = new TextBox();
            SaveFileDialog = new SaveFileDialog();
            ContextStrip = new ContextMenuStrip(components);
            Paste_Btn = new ToolStripMenuItem();
            Refresh_btn = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            ContextStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SpaceOfFiles
            // 
            SpaceOfFiles.AllowDrop = true;
            SpaceOfFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SpaceOfFiles.BackColor = Color.White;
            SpaceOfFiles.Location = new Point(0, 53);
            SpaceOfFiles.Name = "SpaceOfFiles";
            SpaceOfFiles.Padding = new Padding(25);
            SpaceOfFiles.Size = new Size(592, 216);
            SpaceOfFiles.TabIndex = 0;
            SpaceOfFiles.DragDrop += SpaceOfFiles_DragDrop;
            SpaceOfFiles.DragEnter += SpaceOfFiles_DragEnter;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { BackButton, Refresh_btn, fileToolStripMenuItem, editToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(592, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip2";
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.backbtn;
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(60, 20);
            BackButton.Text = "Back";
            BackButton.Click += BackButton_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, ExportSelected });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ImportFile, ImportFolder });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // ImportFile
            // 
            ImportFile.Name = "ImportFile";
            ImportFile.Size = new Size(107, 22);
            ImportFile.Text = "File";
            ImportFile.Click += ImportFile_Click;
            // 
            // ImportFolder
            // 
            ImportFolder.Name = "ImportFolder";
            ImportFolder.Size = new Size(107, 22);
            ImportFolder.Text = "Folder";
            ImportFolder.Click += ImportFolder_Click;
            // 
            // ExportSelected
            // 
            ExportSelected.Name = "ExportSelected";
            ExportSelected.Size = new Size(110, 22);
            ExportSelected.Text = "Export";
            ExportSelected.Click += ExportSelected_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(102, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(102, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // ProgressBar
            // 
            ProgressBar.Dock = DockStyle.Bottom;
            ProgressBar.Location = new Point(0, 275);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(592, 23);
            ProgressBar.TabIndex = 1;
            // 
            // PathOf
            // 
            PathOf.Dock = DockStyle.Top;
            PathOf.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PathOf.Location = new Point(0, 24);
            PathOf.Name = "PathOf";
            PathOf.ReadOnly = true;
            PathOf.Size = new Size(592, 27);
            PathOf.TabIndex = 2;
            PathOf.TextChanged += PathOf_TextChanged;
            // 
            // ContextStrip
            // 
            ContextStrip.Items.AddRange(new ToolStripItem[] { Paste_Btn });
            ContextStrip.Name = "ContextStrip";
            ContextStrip.Size = new Size(103, 26);
            ContextStrip.Opening += ContextStrip_Opening;
            // 
            // Paste_Btn
            // 
            Paste_Btn.Name = "Paste_Btn";
            Paste_Btn.Size = new Size(102, 22);
            Paste_Btn.Text = "Paste";
            Paste_Btn.Click += Paste_Btn_Click;
            // 
            // Refresh_btn
            // 
            Refresh_btn.Image = Properties.Resources.reload;
            Refresh_btn.Name = "Refresh_btn";
            Refresh_btn.Size = new Size(74, 20);
            Refresh_btn.Text = "Refresh";
            Refresh_btn.Click += Refresh_btn_Click;
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 298);
            ContextMenuStrip = ContextStrip;
            Controls.Add(PathOf);
            Controls.Add(SpaceOfFiles);
            Controls.Add(ProgressBar);
            Controls.Add(MenuStrip);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elrouby Decrypted Desktop Plus";
            WindowState = FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ContextStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private FlowLayoutPanel SpaceOfFiles;
        private OpenFileDialog OpenFileDialog;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem ImportFile;
        private ToolStripMenuItem ImportFolder;
        private ProgressBar ProgressBar;
        private FolderBrowserDialog FolderDialog;
        private ToolStripMenuItem ExportSelected;
        public TextBox PathOf;
        private ToolStripMenuItem BackButton;
        private SaveFileDialog SaveFileDialog;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ContextMenuStrip ContextStrip;
        private ToolStripMenuItem Paste_Btn;
        private ToolStripMenuItem Refresh_btn;
    }
}
