using System.Collections.Specialized;
using System.Diagnostics;

namespace EDDPlus.Items
{
    public partial class FileFolderPath : UserControl
    {
        public string PathOf;
        public FileFolderPath()
        {
            InitializeComponent();
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            Main.SelectedItemOf = this;
        }

        private void NameOf_DoubleClick(object sender, EventArgs e)
        {
            if (GetType() == typeof(FileOf))
            {
                var FileCheck = new FileInfo(PathOf);

                if (FileCheck.Length > 10485760)
                {
                    MessageBox.Show("You can't open file more than 10mb this way, Please extract it first", "Prompt Error", MessageBoxButtons.OK);
                    return;
                }

                var TargetFileName = PathOf.Split('\\').Last().Replace(".rouby", "");

                CPPImport.DecryptAll(PathOf, $"C:\\Windows\\Temp\\{TargetFileName}");

                try
                {
                    Process.Start($"C:\\Windows\\Temp\\{TargetFileName}");

                }
                catch
                {
                    MessageBox.Show("Theres no way to open this file, Duo to the default opener", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                Main.MainPage.PathOf.Text += "\\" + this.NameOf.Text;
            }
        }

        private void FileFolderPath_Load(object sender, EventArgs e)
        {
            Tip.SetToolTip(this, NameOf.Text);
            Tip.SetToolTip(PicBox, NameOf.Text);
            Tip.SetToolTip(NameOf, NameOf.Text);
        }

        private void Cut_MenuStrip_Click(object sender, EventArgs e)
        {
            StringCollection Str = new StringCollection()
            {
                PathOf
            };

            Clipboard.SetFileDropList(Str);

            Main.CutPath = PathOf;
        }

        private void Copy_MenuStrip_Click(object sender, EventArgs e)
        {
            StringCollection Str = new StringCollection()
            {
                PathOf
            };

            Clipboard.SetFileDropList(Str);

            Main.CutPath = null;
        }

        private void Delete_MenuStrip_Click(object sender, EventArgs e)
        {
            if (GetType() == typeof(FileOf))
            {
                File.Delete(PathOf);
            }
            else Directory.Delete(PathOf, true);

            Main.MainPage.LoadFilesInSpace(Main.PathOfFiles + Main.MainPage.PathOf.Text);
        }

        private void PropertiesOf_Click(object sender, EventArgs e)
        {
            Main.PropWindow = new Windows.PropertiesWindow(this);
            Main.PropWindow.ShowDialog();
        }

        private void MenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PropertiesOf.Enabled = GetType() == typeof(FileOf);
        }
    }
}
