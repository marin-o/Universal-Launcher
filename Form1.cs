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
        

        private void btnRemove_Click(object sender, EventArgs e) { 
            if (aaaaa.Controls.Count > 0)
                aaaaa.Controls.RemoveAt(aaaaa.Controls.Count - 1);

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
