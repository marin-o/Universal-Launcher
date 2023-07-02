using IWshRuntimeLibrary;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal_Launcher.AppClasses;

namespace Universal_Launcher {
    public partial class Form1 : MetroForm {
        private List<Color> colors;
        private Random r = new Random();
        public Form1() {
            InitializeComponent();
            colors = new List<Color>();
            for (int i = 0; i < 10; i++) {
                colors.Add(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            }
        }
        private uint lblAppNameCount = 0;
        private void btnAddFlow_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
            ofd.Title  = "Select a Shortcut or Executable File";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                ucTest uc = new ucTest(lblAppNameCount);
                string filePath = ofd.FileName;
                string filename = Path.GetFileNameWithoutExtension(filePath);

                App app;

                Icon icon;
                string iconPath;

                if(Path.GetExtension(filePath).Equals(".lnk", StringComparison.OrdinalIgnoreCase)) {
                    IWshShell shell = new WshShell();
                    IWshShortcut link = (IWshShortcut)shell.CreateShortcut(filePath);
                    iconPath = link.IconLocation;

                    Icon extractedIcon = Icon.ExtractAssociatedIcon(iconPath);
                    icon = new Icon(extractedIcon, SystemInformation.SmallIconSize);
                     
                    
                } 
                else {
                    iconPath = filePath;
                    icon = Icon.ExtractAssociatedIcon(filePath);
                }
                MainAppFactory mainAppFactory = new MainAppFactory();
                app = mainAppFactory.CreateApp(filename, filePath, icon, iconPath);
                uc.SetMainApp(app);
                tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if( flpLibrary.Controls.Count > 0 )
                flpLibrary.Controls.RemoveAt(flpLibrary.Controls.Count - 1);
        }
    }
}
