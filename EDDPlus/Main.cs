using EDDPlus.Items;
using EDDPlus.Windows;
using System.ComponentModel;

namespace EDDPlus
{
    public partial class Main : Form
    {
        public static PropertiesWindow PropWindow;
        public void LoadFilesInSpace(string Place)
        {
            SpaceOfFiles.Controls.Clear();

            var AllPaths = CPPImport.GetFilesAndFolders(Place);

            foreach (var path in AllPaths)
            {
                if (Path.GetExtension(path).Length > 0)
                {
                    var NewFile = new FileOf();

                    NewFile.PathOf = path;

                    NewFile.NameOf.Text = path.Split('\\').Last().Replace(".rouby", "");

                    SpaceOfFiles.Controls.Add(NewFile);
                }
                else
                {
                    var NewFile = new FolderOf();

                    NewFile.PathOf = path;

                    NewFile.NameOf.Text = path.Split('\\').Last();

                    SpaceOfFiles.Controls.Add(NewFile);
                }
            }
        }
        private static FileFolderPath selectedItemOf;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static FileFolderPath SelectedItemOf
        {
            get => selectedItemOf;
            set
            {
                if (selectedItemOf != null)
                {
                    selectedItemOf.PicBox.Image = null;
                }

                selectedItemOf = value;

                if (selectedItemOf != null)
                {
                    selectedItemOf.PicBox.Image = Properties.Resources.Select;
                }
            }
        }
        public static string PathOfFiles;
        public static Main MainPage;
        public Main()
        {
            InitializeComponent();

            MainPage = this;

            CheckForIllegalCrossThreadCalls = false;

            PathOfFiles = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            if (!Directory.Exists(PathOfFiles))
            {
                Directory.CreateDirectory(PathOfFiles);
            }

            LoadFilesInSpace(PathOfFiles);


        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static string CutPath { get; set; }
        private void SpaceOfFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            ProgressBar.Maximum = files.Length;

            ProgressFileReach = 0;

            var t = new Thread(() =>
            {
                while (true)
                {
                    ProgressBar.Value = ProgressFileReach;

                    if (ProgressBar.Value >= ProgressBar.Maximum)
                    {
                        break;
                    }
                }
            });

            t.Start();

            foreach (var file in files)
            {
                var CurrentPath = Path.Combine(PathOfFiles + PathOf.Text, file.Split('\\').Last() + ".rouby");
                CPPImport.EncryptAll(file, CurrentPath);

                ProgressFileReach++;
            }

            LoadFilesInSpace(PathOfFiles + "\\" + PathOf.Text);
        }

        private void SpaceOfFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProgressBar.Value = 25;
                CPPImport.EncryptAll(OpenFileDialog.FileName, Path.Combine(PathOfFiles + "\\" + PathOf.Text, OpenFileDialog.FileName.Split('\\').Last() + ".rouby"));
                ProgressBar.Value = 100;

                LoadFilesInSpace(PathOfFiles + "\\" + PathOf.Text);
            }
        }
        int ProgressFileReach = 0;
        private void ImportFolder_Click(object sender, EventArgs e)
        {
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                var FolderPath = FolderDialog.SelectedPath;

                var CurrentDir = Path.Combine(PathOfFiles + "\\" + PathOf.Text, FolderPath.Split('\\').Last());

                Directory.CreateDirectory(CurrentDir);

                var GetFilesPaths = CPPImport.GetFilesAndFolders(FolderPath);

                ProgressBar.Maximum = GetFilesPaths.Count();

                var t = new Thread(() =>
                {
                    while (true)
                    {
                        ProgressBar.Value = ProgressFileReach;

                        if (ProgressBar.Value >= ProgressBar.Maximum)
                        {
                            break;
                        }
                    }
                });

                t.Start();

                foreach (var file in GetFilesPaths)
                {
                    var CurrentPath = Path.Combine(CurrentDir, file.Split('\\').Last() + ".rouby");
                    CPPImport.EncryptAll(file, CurrentPath);

                    ProgressFileReach++;
                }

                LoadFilesInSpace(PathOfFiles + "\\" + PathOf.Text);
            }
        }

        private void PathOf_TextChanged(object sender, EventArgs e)
        {
            LoadFilesInSpace(Path.Combine(PathOfFiles + "\\" + PathOf.Text));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (PathOf.Text.Contains("\\"))
            {
                var PathParts = PathOf.Text.Split('\\').ToList();

                foreach (var part in PathParts.ToList())
                {
                    if (part.Length == 0)
                    {
                        PathParts.Remove(part);
                    }
                }

                var Grouping = "";

                for (int i = 0; i < PathParts.Count() - 1; i++)
                {
                    if (PathParts[i].Length > 0)
                        Grouping += PathParts[i] + "\\";
                }

                PathOf.Text = Grouping;
            }
        }

        private void ExportSelected_Click(object sender, EventArgs e)
        {
            if (SelectedItemOf is FileOf)
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CPPImport.DecryptAll(SelectedItemOf.PathOf, SaveFileDialog.FileName);
                }
            }
            else if (selectedItemOf is FolderOf)
            {
                if (FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    ProgressFileReach = 0;

                    var t = new Thread(() =>
                    {
                        while (true)
                        {
                            ProgressBar.Value = ProgressFileReach;

                            if (ProgressBar.Value >= ProgressBar.Maximum)
                            {
                                break;
                            }
                        }
                    });

                    var Files = CPPImport.GetFilesAndFolders(SelectedItemOf.PathOf);
                    ProgressBar.Maximum = Files.Count();
                    t.Start();
                    foreach (var file in Files)
                    {
                        CPPImport.DecryptAll(file, FolderDialog.SelectedPath + "\\" + file.Split('\\').Last().Replace(".rouby", ""));

                        ProgressFileReach++;
                    }
                }
                else MessageBox.Show("Please select a file or folder", "Hey");
            }
        }

        private void Paste_Btn_Click(object sender, EventArgs e)
        {
            var Files = Clipboard.GetFileDropList();

            if (Files.Count > 0)
            {
                var TargetNamePath = Files[0].Replace(".rouby", "").Split('\\').Last();

                var AllTargets = PathOfFiles + PathOf.Text + "\\" + TargetNamePath;

                bool Delete = false;

                if (File.Exists(AllTargets))
                {
                    var result = MessageBox.Show("File with the same name already exist, Do you want to replace it?", "Prompt", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        Delete = true;
                    }
                    else return;
                }

                File.Copy(Files[0], AllTargets);

                if (Delete)
                {
                    File.Delete(AllTargets);
                }
            }

            if (CutPath != null && CutPath.Length > 0)
            {
                File.Delete(CutPath);

                CutPath = null;
            }

            MainPage.LoadFilesInSpace(PathOfFiles + MainPage.PathOf.Text);

            CutPath = null;
        }

        private void ContextStrip_Opening(object sender, CancelEventArgs e)
        {
            Paste_Btn.Enabled = Clipboard.GetFileDropList().Count > 0;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            LoadFilesInSpace(PathOfFiles + MainPage.PathOf.Text);
        }
    }
}
