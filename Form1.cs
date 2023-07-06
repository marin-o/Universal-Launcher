using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Notes_Items;
using Universal_Launcher.Reminders_Items;
using static Universal_Launcher.App_Items.AppUtilities;

namespace Universal_Launcher {
    public partial class Form1 : MetroForm {
        private Note activeNote = null;
        /*
        * Reminders repository contains a list of reminders
        */
        private RemindersRepository reminder = new RemindersRepository(); //serializable
        /*
         * Notes repository contains a list of notes
         */
        private NotesRepository notes = new NotesRepository(); //serializable 
        /*
         * App repository contains the list of flow layout panels that contain the apps and the apps themselves (in the flow layout panels)
         */
        private AppRepository apps = new AppRepository(); //serializable
        public AppRepository Apps { 
            get {
                return apps;
            }
        }
        public Form1() {
            InitializeComponent();
        }

        private void btnAddFlow_Click(object sender, EventArgs e) {
            AppUserControl uc = GenerateMainAppCard(this);
            if(uc != null ) {
                uc.AppDeleted += AppCard_AppDeleted;
                tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc);
                apps.AddApp(uc);
            }
        }

        private void AppCard_AppDeleted(object sender, EventArgs e) {
            AppUserControl uc = sender as AppUserControl;
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Remove(uc);
            apps.RemoveApp(uc);
            uc.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if( flpLibrary.Controls.Count > 0 ) 
                flpLibrary.Controls.RemoveAt(flpLibrary.Controls.Count - 1);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            CreateNote note = new CreateNote();
            if (note.ShowDialog() == DialogResult.OK)
            {
                lbNotes.Items.Add(note.Note);
                notes.Add(note.Note);
            }
        }

        private void btnRemoveNotes_Click(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                notes.Remove(notes.Notes[lbNotes.SelectedIndex]);
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
                
                reminder.AddReminder(newReminder.Reminder);
                lvReminders.Items.Add(newReminder.Reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.DateTime.Date.ToString());
            }
        }

        private void lvReminders_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                reminder.RemoveReminder(reminder.Reminders[e.Item.Index]);
                e.Item.Remove();
            }
        }
    }
}
