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
    public partial class NewReminder : MetroForm
    {
       public Reminders Reminders;
       public Reminder Reminder { get; set; }
        public NewReminder() {
            InitializeComponent();
            Reminders = new Reminders();
        }

        private void mtbTask_Validating(object sender, CancelEventArgs e)
        {
            if(mtbTask.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbTask, "Please enter a task");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtbTask, null);
            }
        }

        private void DtReminder_Validating(object sender, CancelEventArgs e)
        {
            if(DtReminder.Value < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(DtReminder, "Please enter a valid date");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DtReminder, null);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                Reminder = new Reminder(mtbTask.Text, DtReminder.Value);
                Reminders.AddReminder(Reminder);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
        }
    }
}
