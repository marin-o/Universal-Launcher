using MetroFramework;
using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Resources;

namespace Universal_Launcher {

    public partial class AppUserControl : UserControl {
        private App mainApp;
        public string Id { get; set; }
        public event EventHandler AppDeleted;
        public AppUserControl(string id) {
            InitializeComponent();
            Id = id;
            cbAddSubApp.SelectedIndex = 0;
        }

        public void SetMainApp(App app) {
            mainApp = app;
            lblAppName.Text = app.Name;
            pbAppIcon.Image = app.Icon.ToBitmap();
        }

        private void btnDel_Click(object sender, EventArgs e) {
            AppDeleted?.Invoke(this, EventArgs.Empty);
        }

        private void pbAppIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if( e.Button == MouseButtons.Left )
                mainApp.Launch();
        }

        private void btnAddSubApp_Click(object sender, EventArgs e) {
            flpSubApps.Controls.Add(new SubAppsUserControl());
        }

        private void cbAddSubApp_SelectedIndexChanged(object sender, EventArgs e) {
            if( cbAddSubApp.SelectedIndex == 1 ) {
                SubAppsUserControl uc = AppUtilities.GenerateExeSubApp(this);
                if( uc != null )
                    flpSubApps.Controls.Add(uc);
            }
            else if( cbAddSubApp.SelectedIndex == 2 ) {
                SubAppsUserControl uc = AppUtilities.GenerateFolderSubApp(this, mainApp);
                if( uc != null )
                    flpSubApps.Controls.Add(uc);
            }
            cbAddSubApp.SelectedIndex = 0;
        }
    }
}
