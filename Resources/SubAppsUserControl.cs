using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal_Launcher.App_Items;

namespace Universal_Launcher.Resources {
    [Serializable]
    public partial class SubAppsUserControl : UserControl {
        public App SubApp { get; set; }
        public SubAppsUserControl() {
            InitializeComponent();
        }

        public void SetApp(App app) {
            SubApp = app;
            lblAppName.Text = app.Name;
            pbAppIcon.Image = app.Icon.ToBitmap();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            Parent.Controls.Remove(this);
        }

        private void pbAppIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left)
                SubApp.Launch();
        }
    }
}
