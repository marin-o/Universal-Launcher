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
       public Note note;
        public CreateNote()
        {
            InitializeComponent();
            
        }

        private void mtbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (mtbTitle.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProviderTitle.SetError(mtbTitle, "Vnesi Naslov!");
            }
            else
            {
                e.Cancel = false;
                errorProviderTitle.SetError(mtbTitle, null);
            }
        }

        private void mtbNote_Click(object sender, EventArgs e)
        {

        }

        private void mtbNote_Validating(object sender, CancelEventArgs e)
        {
            if (mtbNote.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProviderTitle.SetError(mtbNote, "Vnesi Naslov!");
            }
            else
            {
                e.Cancel = false;
                errorProviderTitle.SetError(mtbNote, null);
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                note = new Note(mtbTitle.Text, mtbNote.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
