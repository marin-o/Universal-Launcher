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
            this.StyleManager = msmNewNote;
        }

        public CreateNote(string body) {
            InitializeComponent();
            mtbNote.Text = body;
            this.StyleManager = msmNewNote;
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

        public void DarkMode(bool IsDark)
        {
            if(IsDark)
            {
                msmNewNote.Theme = MetroFramework.MetroThemeStyle.Dark;
                mtbTitle.ForeColor = Color.White;
                mtbNote.ForeColor = Color.White;
                mtbTitle.BackColor = Color.FromArgb(255, 100, 100, 100);
                mtbNote.BackColor = Color.FromArgb(255, 100, 100, 100);
            }
            else
            {
                msmNewNote.Theme = MetroFramework.MetroThemeStyle.Light;
                mtbTitle.ForeColor = Color.Black;
                mtbNote.ForeColor = Color.Black;
                mtbTitle.BackColor = Color.White;
                mtbNote.BackColor = Color.White;
            }
        }
    }
}
