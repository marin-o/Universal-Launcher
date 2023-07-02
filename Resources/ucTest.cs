using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal_Launcher.AppClasses;

namespace Universal_Launcher {
    public partial class ucTest : UserControl {
        private App mainApp;
        public string Id { get; set; }
        public ucTest(string id) {
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
            mainApp.Launch();
        }
        
    }
}
