using EDDPlus.Helper;
using EDDPlus.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDPlus.Windows
{
    public partial class PropertiesWindow: Form
    {
        public PropertiesWindow(FileFolderPath pathof)
        {
            InitializeComponent();

            Text = "Properties: " + pathof.NameOf.Text.Split('\\').Last();

            NameOfItem.Text = pathof.NameOf.Text;
            FullPathOf.Text = pathof.PathOf;
            SizeOf.Text = new FileInfo(FullPathOf.Text).Length.ToString();

            var PathSplit = FullPathOf.Text.Split('\\');
            bool Gotten = false;

            var SpacePath = "";

            for (int i = 0; i < PathSplit.Length; i++)
            {
                if (Gotten)
                {
                    SpacePath += PathSplit[i] + "\\";
                    continue;
                }
                if (PathSplit[i] == "Data")
                {
                    Gotten = true;
                }
            }

            PathInSpace.Text = SpacePath;

            IconBox.BackgroundImage = FileIconHelper.GetFileIcon(FullPathOf.Text).ToBitmap();
        }
    }
}
