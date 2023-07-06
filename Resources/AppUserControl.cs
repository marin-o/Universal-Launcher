using MetroFramework;
using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Resources;

namespace Universal_Launcher {
    public partial class AppUserControl : UserControl {
        private App mainApp;
        public string Id { get; set; }
        public AppUserControl(string id) {
            InitializeComponent();
            Id = id;
        }

        public void SetMainApp(App app) {
            mainApp = app;
            lblAppName.Text = app.Name;
            pbAppIcon.Image = app.Icon.ToBitmap();
        }

        private void btnDel_Click(object sender, EventArgs e) {
            this.Parent.Controls.Remove(this);
        }

        private void pbAppIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left)
                mainApp.Launch();
        }

        private void btnAddSubApp_Click(object sender, EventArgs e) {
            flpSubApps.Controls.Add(new SubAppsUserControl());
        }

        private void cbAddSubApp_SelectedIndexChanged(object sender, EventArgs e) {
            lblAdd.Visible = false;
            if( cbAddSubApp.SelectedIndex == 0 ) {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
                ofd.Title = "Select an Executable File, Shortcut, or Link File";
                if( ofd.ShowDialog() == DialogResult.OK ) {
                    SubAppsUserControl uc = new SubAppsUserControl();
                    try {
                        AppInfo info = AppUtilities.GetAppInfo(ofd.FileName);
                        App app = AppUtilities.GetSubApp(info);
                        uc.SetApp(app);
                        flpSubApps.Controls.Add(uc);
                    }
                    catch( AppDoesNotExistException ex ) {
                        MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if( cbAddSubApp.SelectedIndex == 1 ) {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select a Folder";
                if( fbd.ShowDialog() == DialogResult.OK ) {
                    string path = fbd.SelectedPath;
                    SubAppsUserControl uc = new SubAppsUserControl();
                    AppInfo info = AppUtilities.GetAppInfo(path);
                    SubApp app = AppUtilities.GetSubApp(info) as SubApp;
                    app.Parent = mainApp;
                    uc.SetApp(app);
                    flpSubApps.Controls.Add(uc);
                }
            }
            cbAddSubApp.SelectedIndex = -1;
            lblAdd.Visible = true;

        }
    }
}
