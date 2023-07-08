using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal_Launcher.App_Items;
using Universal_Launcher.Notes_Items;
using Universal_Launcher.Reminders_Items;


namespace Universal_Launcher {
    public partial class Form1 : MetroForm {
        private Note activeNote = null;
        /*
        * Reminders repository contains a list of reminders
        */
        private RemindersRepository reminders = new RemindersRepository(); //serializable
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
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            Deserialize();
        }

        private void AddUc(AppUserControl uc) {
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc);
            uc.AppDeleted += AppCard_AppDeleted;
        }

        private void btnAddFlow_Click(object sender, EventArgs e) {
            AppUserControl uc = AppUtilities.GenerateMainAppCard(this);
            if(uc != null ) {
                AddUc(uc);
                apps.AddApp(uc.MainApp);
            }
        }

        private void AppCard_AppDeleted(object sender, EventArgs e) {
            AppUserControl uc = sender as AppUserControl;
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Remove(uc);
            apps.RemoveApp(uc.MainApp);
            uc.Dispose();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            CreateNote note;
            if( rtbNotes.Text != string.Empty ) {
                note = new CreateNote(rtbNotes.Text);
            }
            else {
                note = new CreateNote();
            }
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
                if (activeNote.IsPinned) {
                    lblNoteTitleSideBar.Text = "";
                    rtbSideBarNoteText.Text = "";
                }
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

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            NewReminder newReminder = new NewReminder();
            if(newReminder.ShowDialog() == DialogResult.OK)
            {
                lvReminders.CheckBoxes = true;
                
                reminders.AddReminder(newReminder.Reminder);
                lvReminders.Items.Add(newReminder.Reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.DateTime.Date.ToString());
                lvSideBarReminders.Items.Add(newReminder.Reminder.Task);
                lvSideBarReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.DateTime.Date.ToString());
            }
        }

        private void lvReminders_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                reminders.RemoveReminder(reminders.Reminders[e.Item.Index]);
                if( lvSideBarReminders.Items.Count > 0 ) {
                    lvSideBarReminders.Items[e.Item.Index].Remove();
                }
                e.Item.Remove();
            }
        }
        private void lvSideBarReminders_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if( e.Item.Checked ) {
                reminders.RemoveReminder(reminders.Reminders[e.Item.Index]);
                if( lvReminders.Items.Count > 0 ) {
                    lvReminders.Items[e.Item.Index].Remove();
                }
                e.Item.Remove();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Serialize();
        }

        private void lbNotes_MouseHover(object sender, EventArgs e) {
            ttTipDoubleClick.Show("Double click to pin note", lbNotes);
        }

        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e) {
            if( lbNotes.SelectedIndex != -1 ) {
                activeNote = lbNotes.SelectedItem as Note;
                if( activeNote != null ) {
                    rtbNotes.Text = activeNote.Body;
                }
            }
        }

        private void lbNotes_MouseDoubleClick(object sender, MouseEventArgs e) {
            if( e.Button == MouseButtons.Left ) {
                Note note = lbNotes.SelectedItem as Note;
                notes.PinNote(note);
                ResetLbNotes();

                lblNoteTitleSideBar.Text = note.Title;
                rtbSideBarNoteText.Text = note.Body;
            }
        }

        private void ResetLbNotes() {
            lbNotes.Items.Clear();
            foreach( Note note in notes.Notes ) {
                lbNotes.Items.Add(note);
            }
        }

        //Serialization and deserialization

        private void Serialize() {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;

            string appPath = Path.Combine(exePath, "apps.ul");
            SerializeToBinary(apps, appPath);
            string notesPath = Path.Combine(exePath, "notes.ul");
            SerializeToBinary(notes, notesPath);
            string remindersPath = Path.Combine(exePath, "reminders.ul");
            SerializeToBinary(reminders, remindersPath);
        }
        private void SerializeToBinary(object data, string path) {
            IFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            f.Serialize(s, data);
            s.Close();
        }
        private void Deserialize() {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string appPath = Path.Combine(exePath, "apps.ul");
            string notesPath = Path.Combine(exePath, "notes.ul");
            string remindersPath = Path.Combine(exePath, "reminders.ul");

            DeserializeApps(appPath);
            PopulateApps();
            DeserializeNotes(notesPath);
            PopulateNotes();
            DeserializeReminders(remindersPath);
            PopulateReminders();
        }


        private void DeserializeApps(string path) {
            try {
                FileStream s = new FileStream(path, FileMode.Open);
                IFormatter f = new BinaryFormatter();
                apps = f.Deserialize(s) as AppRepository;
                s.Close();
            }
            catch( FileNotFoundException ex ) {
                //MetroMessageBox.Show(this, "There is no apps save file to deserialize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void DeserializeNotes(string path) {
            try {
                FileStream s = new FileStream(path, FileMode.Open);
                    IFormatter f = new BinaryFormatter();
                    notes = f.Deserialize(s) as NotesRepository;
                    s.Close();
            } catch (FileNotFoundException ex) {
                //MetroMessageBox.Show(this, "There is no notes save file to deserialize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeserializeReminders(string path) {
            try {
                FileStream s = new FileStream(path, FileMode.Open);
                IFormatter f = new BinaryFormatter();
                reminders = f.Deserialize(s) as RemindersRepository;
                s.Close();
            }
            catch( FileNotFoundException ex ) {
                //MetroMessageBox.Show(this, "There is no reminders save file to deserialize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateApps() {
            foreach (MainApp app in apps.Apps ) {
                AppUserControl uc = AppUtilities.RegenrateAUC(app);
                uc.Parent = this;
                AddUc(uc);
            }
        }

        private void PopulateNotes() {
            foreach (Note note in notes.Notes) {
                lbNotes.Items.Add(note);
            }
        }

        private void PopulateReminders() {
            foreach (Reminder reminder in reminders.Reminders) {
                lvReminders.Items.Add(reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(reminder.DateTime.Date.ToString());
            }
            lvReminders.Update();
        }

        
    }
}
