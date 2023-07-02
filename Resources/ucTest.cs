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
    public partial class ucTest : UserControl {
        public uint Id { get; set; }
        public ucTest(uint id) {
            InitializeComponent();
            Id = id;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            this.Parent.Controls.Remove(this);
        }
    }
}
