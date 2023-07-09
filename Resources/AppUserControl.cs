using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Resources;

namespace Universal_Launcher {
    [Serializable]
    public partial class AppUserControl : UserControl {
        private MainApp mainApp;
        public MainApp MainApp { get { return mainApp; } }
        private bool ChangeCategory = false;

        public event EventHandler AppDeleted;
        public event EventHandler<App> AppLaunched;
        public event EventHandler<string> CategoryChanged;

        public AppUserControl() {
            InitializeComponent();
            cbAddSubApp.SelectedIndex = -1;
        }

        public AppUserControl(MainApp app) {
            InitializeComponent();
            cbAddSubApp.SelectedIndex = -1;
            SetMainApp(app);
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
            if( cbAddSubApp.SelectedIndex == 0 ) {
                SubAppsUserControl uc = AppUtilities.GenerateExeSubApp(this);
                if( uc != null ) {
                    flpSubApps.Controls.Add(uc);
                    mainApp.AddApp(uc.SubApp);
                }
                    
            }
            else if( cbAddSubApp.SelectedIndex == 1 ) {
                SubAppsUserControl uc = AppUtilities.GenerateFolderSubApp(this, mainApp);
                if( uc != null ) {
                    flpSubApps.Controls.Add(uc);
                    mainApp.AddApp(uc.SubApp);
                }
            }
            cbAddSubApp.SelectedIndex = -1;
        }

        private void lblAppName_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left ) {
                tbChangeNameOrCategory.WaterMark = "Enter new name";
                tbChangeNameOrCategory.Visible = true;
                tbChangeNameOrCategory.Enabled = true;
            }
        }

        private void tbChangeNameOrCategory_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter && !ChangeCategory) {
                mainApp.Name = lblAppName.Text.Trim(); ;
                lblAppName.Text = mainApp.Name;
                tbChangeNameOrCategory.Visible = false;
                tbChangeNameOrCategory.Enabled = false;
                tbChangeNameOrCategory.Text = "";
            } else if(e.KeyCode == Keys.Enter && ChangeCategory) { 
                string oldCategory = mainApp.Category;
                mainApp.Category = tbChangeNameOrCategory.Text.Trim();
                CategoryChanged?.Invoke(oldCategory, mainApp.Category);
                tbChangeNameOrCategory.Visible = false;
                tbChangeNameOrCategory.Enabled = false;
                ChangeCategory = false;
                tbChangeNameOrCategory.Text = "";
            }
            else if(e.KeyCode == Keys.Escape) {
                tbChangeNameOrCategory.Visible = false;
                tbChangeNameOrCategory.Enabled = false;
                tbChangeNameOrCategory.Text = "";
            }
            
        }

        private void btnFavorite_Click(object sender, EventArgs e) {
            Universal_Launcher parent = (Universal_Launcher)ParentForm;
            parent.AddAppToFavorites(MainApp);
        }

        private void ibChangeCategory_Click(object sender, EventArgs e) {
            tbChangeNameOrCategory.Visible = true;
            tbChangeNameOrCategory.Enabled = true;
            ChangeCategory = true;
            tbChangeNameOrCategory.WaterMark = "Enter a category...";
        }
    }
}
