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

namespace Universal_Launcher
{
    public partial class CreateNote : MetroForm
    {
        public Note Note { get; set; }
        public CreateNote() {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                Note = new Note(mtbTitle.Text, mtbNote.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
