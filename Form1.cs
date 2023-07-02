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
        private MainAppFactory mainAppFactory;
        public Form1() {
            InitializeComponent();
            mainAppFactory = new MainAppFactory();
        }

        private void btnAddFlow_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
            ofd.Title  = "Select an Executable File, Shortcut, or Link File";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                AppUserControl uc = new AppUserControl(Guid.NewGuid().ToString());
                ShortcutInfo info = AppUtilities.GetShortcutInfo(ofd.FileName);
                App app = mainAppFactory.CreateApp(info.Name, info.FilePath, info.IconPath, info.Icon);
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
