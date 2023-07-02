using MetroFramework.Forms;
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
            UserControl uc = new ucTest(lblAppNameCount);
            uc.BackColor = colors[r.Next(colors.Count)];
            uc.Controls.Find("lblAppName", true)[0].Text = $"Test{lblAppNameCount++}";
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if( flpLibrary.Controls.Count > 0 )
                flpLibrary.Controls.RemoveAt(flpLibrary.Controls.Count - 1);
        }
    }
}
