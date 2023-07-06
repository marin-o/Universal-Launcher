using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;

namespace Universal_Launcher {
    public partial class Form1 : MetroForm {
        private Note activeNote = null;
        private RemindersRepository Reminders { get; set;}
        public Form1() {
            InitializeComponent();
        }

        private void btnAddFlow_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
            ofd.Title = "Select an Executable File, Shortcut, or Link File";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                AppUserControl uc = new AppUserControl(Guid.NewGuid().ToString());
                try {
                    AppInfo info = AppUtilities.GetAppInfo(ofd.FileName);
                    App app = AppUtilities.GetMainApp(info);
                    uc.SetMainApp(app);
                    tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc); 
                } catch (AppDoesNotExistException ex){
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if( flpLibrary.Controls.Count > 0 )
                flpLibrary.Controls.RemoveAt(flpLibrary.Controls.Count - 1);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            CreateNote notes = new CreateNote();
            if (notes.ShowDialog() == DialogResult.OK)
            {
                lbNotes.Items.Add(notes.Note);
            }
        }

        private void btnRemoveNotes_Click(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                lbNotes.Items.RemoveAt(lbNotes.SelectedIndex);
                rtbNotes.Text = "";
            }
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            if(activeNote != null)
            {
                activeNote.Body = rtbNotes.Text;
            }
        }

        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                activeNote = lbNotes.SelectedItem as Note;
                if(activeNote != null)
                {
                    rtbNotes.Text = activeNote.Body;
                }
            }
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            NewReminder newReminder = new NewReminder();
            if(newReminder.ShowDialog() == DialogResult.OK)
            {
                lvReminders.CheckBoxes = true;
                
                Reminders = newReminder.Reminders;
                lvReminders.Items.Add(newReminder.Reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.DateTime.Date.ToString());
            }
        }

        private void lvReminders_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.Remove();
            }
        }
    }
}
