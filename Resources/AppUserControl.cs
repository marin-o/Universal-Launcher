using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Resources;

namespace Universal_Launcher {
    [Serializable]
    public partial class AppUserControl : UserControl {
        private MainApp mainApp;
        public MainApp MainApp { get { return mainApp; } }
        public string Id { get; set; }
        public event EventHandler AppDeleted;
        public event EventHandler<App> AppLaunched;

        public AppUserControl(string id) {
            InitializeComponent();
            Id = id;
            cbAddSubApp.SelectedIndex = 0;
        }

        public AppUserControl(MainApp app) {
            InitializeComponent();
            cbAddSubApp.SelectedIndex = 0;
            SetMainApp(app);
            //Parent = universalLauncherMainForm.Controls.Find("flpLibrary", true)[0];
        }

        public void SetMainApp(MainApp app) {
            mainApp = app;
            AppUtilities.RedrawIcons(this);
            lblAppName.Text = app.Name;
            pbAppIcon.Image = app.Icon.ToBitmap();
            PopulateSubApps(app);
        }
        private void PopulateSubApps(MainApp app) {
            foreach (App a in app.SubApps ) {
                SubAppsUserControl uc = new SubAppsUserControl();
                uc.SetApp(a);
                flpSubApps.Controls.Add(uc);
            }
        }

        private void btnDel_Click(object sender, EventArgs e) {
            AppDeleted?.Invoke(this, EventArgs.Empty);
        }

        private void pbAppIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if( e.Button == MouseButtons.Left ) {
                mainApp.Launch();
                EventArgs eventArgs = new EventArgs();
                AppLaunched?.Invoke(null,mainApp);
            }
        }

        private void btnAddSubApp_Click(object sender, EventArgs e) {
            flpSubApps.Controls.Add(new SubAppsUserControl());
        }

        private void cbAddSubApp_SelectedIndexChanged(object sender, EventArgs e) {
            if( cbAddSubApp.SelectedIndex == 1 ) {
                SubAppsUserControl uc = AppUtilities.GenerateExeSubApp(this);
                if( uc != null ) {
                    flpSubApps.Controls.Add(uc);
                    mainApp.AddApp(uc.SubApp);
                }
                    
            }
            else if( cbAddSubApp.SelectedIndex == 2 ) {
                SubAppsUserControl uc = AppUtilities.GenerateFolderSubApp(this, mainApp);
                if( uc != null ) {
                    flpSubApps.Controls.Add(uc);
                    mainApp.AddApp(uc.SubApp);
                }
            }
            cbAddSubApp.SelectedIndex = 0;
        }

        private void lblAppName_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left ) {
                tbChangeName.Visible = true;
                tbChangeName.Enabled = true;
            }
        }

        private void tbChangeName_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter ) {
                lblAppName.Text = tbChangeName.Text;
                mainApp.Name = lblAppName.Text;
                tbChangeName.Visible = false;
                tbChangeName.Enabled = false;
                tbChangeName.Text = "";
            } else if(e.KeyCode == Keys.Escape ) {
                tbChangeName.Visible = false;
                tbChangeName.Enabled = false;
                tbChangeName.Text = "";
            }
            
        }

        private void btnFavorite_Click(object sender, EventArgs e) {
            Form1 parent = (Form1)ParentForm;
            parent.AddAppToFavorites(MainApp);
        }

    }
}
