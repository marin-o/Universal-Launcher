using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
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
        public bool IsDark { get; set; }
        public Form1() {
            InitializeComponent();
            DoubleBuffered = true;
            lvFavorites.View = View.LargeIcon;
            lvFavorites.LargeImageList = imgListIcons;
            lvFavorites.Columns.Add("App Name",100);
            lvFavorites.Columns.Add("Icon",100);
            this.StyleManager = msmForm1;
            IsDark = false;
            DeserializeDark();
            IsDark = !IsDark;
            ibDarkMode_MouseClick(null, null);
        }

        private void AddUc(AppUserControl uc) {
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Add(uc);
            uc.AppDeleted += AppCard_AppDeleted;
            uc.AppLaunched += AppCard_AppLaunched;
        }

        private void AppCard_AppLaunched(object sender, App e) {
            if( lbRecentlyUsed.Items.Count == 5 ) {
                lbRecentlyUsed.Items[Apps.RecentlyUsedIndex] = e;
            } else {
                lbRecentlyUsed.Items.Add(e);
            }
            Apps.AddRecentlyUsed(e);
        }
        private void AppCard_AppDeleted(object sender, EventArgs e) {
            AppUserControl uc = sender as AppUserControl;
            tpTestChildren.Controls.Find("flpLibrary", true)[0].Controls.Remove(uc);
            apps.RemoveApp(uc.MainApp);
            uc.Dispose();
        }

        private void btnAddFlow_Click(object sender, EventArgs e) {
            AppUserControl uc = AppUtilities.GenerateMainAppCard(this);
            if( uc != null ) {
                AddUc(uc);
                apps.AddApp(uc.MainApp);
            }
        }


        private void btnAddNote_Click(object sender, EventArgs e) {
            CreateNote note;
            if( rtbNotes.Text != string.Empty && lbNotes.SelectedIndex == -1 ) {
                note = new CreateNote(rtbNotes.Text);
            }
            else {
                note = new CreateNote();
            }
            if( note.ShowDialog() == DialogResult.OK ) {
                lbNotes.Items.Add(note.Note);
                notes.Add(note.Note);
            }
        }

        private void btnRemoveNotes_Click(object sender, EventArgs e) {
            if( lbNotes.SelectedIndex != -1 ) {
                if( activeNote.IsPinned ) {
                    mtbNoteTitleSidebar.Text = "";
                    rtbSideBarNoteText.Text = "";
                }
                notes.Remove(notes.Notes[lbNotes.SelectedIndex]);
                lbNotes.Items.RemoveAt(lbNotes.SelectedIndex);
                rtbNotes.Text = "";
            }
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e) {
            if( activeNote != null ) {
                activeNote.Body = rtbNotes.Text;
            }
        }

        private void btnAddReminder_Click(object sender, EventArgs e) {
            NewReminder newReminder = new NewReminder();
            if( newReminder.ShowDialog() == DialogResult.OK ) {
                lvReminders.CheckBoxes = true;

                reminders.AddReminder(newReminder.Reminder);
                lvReminders.Items.Add(newReminder.Reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.GetDate());
                lvSideBarReminders.Items.Add(newReminder.Reminder.Task);
                lvSideBarReminders.Items[lvSideBarReminders.Items.Count - 1].SubItems.Add(newReminder.Reminder.GetDate());
            }
        }

        private void lvReminders_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if( e.Item.Checked ) {
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

                mtbNoteTitleSidebar.Text = note.Title;
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

            string appPath = Path.Combine(exePath, $"apps-{lblCurrentUser.Text}.ul");
            SerializeToBinary(apps, appPath);
            string notesPath = Path.Combine(exePath, $"notes-{lblCurrentUser.Text}.ul");
            SerializeToBinary(notes, notesPath);
            string remindersPath = Path.Combine(exePath, $"reminders-{lblCurrentUser.Text}.ul");
            SerializeToBinary(reminders, remindersPath);
            string darkPath = Path.Combine(exePath, $"dark.ul");
            SerializeToBinary(IsDark, darkPath);
        }
        private void SerializeToBinary(object data, string path) {
            IFormatter f = new BinaryFormatter();
            FileStream s = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            f.Serialize(s, data);
            s.Close();
        }
        private void Deserialize() {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string appPath = Path.Combine(exePath, $"apps-{lblCurrentUser.Text}.ul");
            string notesPath = Path.Combine(exePath, $"notes-{lblCurrentUser.Text}.ul");
            string remindersPath = Path.Combine(exePath, $"reminders-{lblCurrentUser.Text}.ul");

            DeserializeApps(appPath);
            PopulateApps();
            DeserializeNotes(notesPath);
            PopulateNotes();
            DeserializeReminders(remindersPath);
            PopulateReminders();
            
        }

        private void DeserializeDark() {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string darkPath = Path.Combine(exePath, $"dark.ul");

            try {
                FileStream s = new FileStream(darkPath, FileMode.Open);
                IFormatter f = new BinaryFormatter();
                IsDark = (bool)f.Deserialize(s);
                s.Close();
            }
            catch( FileNotFoundException ex ) {
                //MetroMessageBox.Show(this, "There is no dark save file to deserialize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            }
            catch( FileNotFoundException ex ) {
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
            foreach( MainApp app in apps.Apps ) {
                AppUserControl uc = AppUtilities.RegenrateAUC(app);
                uc.Parent = this;
                AddUc(uc);
            }

            foreach( App app in apps.Favorites ) {
                AddAppToFavoritesNoRepo(app);
            }

            if( apps.RecentlyUsed != null ) {
                foreach( App app in apps.RecentlyUsed ) {
                    lbRecentlyUsed.Items.Add(app);
                }
            }
        }
        private void AddAppToFavoritesNoRepo(App app) {
            imgListIcons.Images.Add(app.Icon);
            ListViewItem i = new ListViewItem(app.Name, imgListIcons.Images.Count - 1);
            i.Tag = app;
            lvFavorites.Items.Add(i);
        }
        private void PopulateNotes() {
            foreach( Note note in notes.Notes ) {
                lbNotes.Items.Add(note);
            }
            if( notes.PinnedNote != null ) {
                mtbNoteTitleSidebar.Text = notes.PinnedNote.Title;
                rtbSideBarNoteText.Text = notes.PinnedNote.Body;
            }
        }

        private void PopulateReminders() {
            foreach( Reminder reminder in reminders.Reminders ) {
                lvReminders.Items.Add(reminder.Task);
                lvReminders.Items[lvReminders.Items.Count - 1].SubItems.Add(reminder.GetDate());
                lvSideBarReminders.Items.Add(reminder.Task);
                lvSideBarReminders.Items[lvSideBarReminders.Items.Count - 1].SubItems.Add(reminder.GetDate());
            }
            lvReminders.Update();
        }

        private bool checkUsername() {
            if( mtbEnterUsername.Text == string.Empty )
                return false;
            else {
                mtbEnterUsername.Text.Trim();
                foreach (char c in mtbEnterUsername.Text) {
                    if (char.IsWhiteSpace(c)) {
                        return false;
                    }
                }
            }
            return true;
        }

        public void AddAppToFavorites(App app) {
            foreach(ListViewItem item in lvFavorites.Items) {
                if( (item.Tag as App).Name.Equals(app.Name ) ){
                    return;
                }
            }
            imgListIcons.Images.Add(app.Icon);
            ListViewItem i = new ListViewItem(app.Name, imgListIcons.Images.Count - 1);
            i.Tag = app;
            lvFavorites.Items.Add(i);
            Apps.AddFavorite(app);
        }

        private void mtbEnterUsername_KeyDown(object sender, KeyEventArgs e) {
            if( e.KeyCode == Keys.Enter ) {

                if( checkUsername() ) { 
                    mtbEnterUsername.Text.Trim();
                    lblCurrentUser.Text = mtbEnterUsername.Text;
                    mpLoginScreen.Dispose();
                    Deserialize();
                }
            }
        }

        private void ibDarkMode_MouseClick(object sender, MouseEventArgs e)
        {
            IsDark = !IsDark;
            if (IsDark)
            {
                msmForm1.Theme = MetroFramework.MetroThemeStyle.Dark;
                panelFavorites.BackColor = Color.FromArgb(255, 44, 45, 45);
                panel2.BackColor = Color.FromArgb(255, 44, 45, 45);
                panel3.BackColor = Color.FromArgb(255, 44, 45, 45);
                ibDarkMode.IconChar = FontAwesome.Sharp.IconChar.Sun;
                lvFavorites.BackColor = Color.FromArgb(255, 100, 100, 100);
                rtbNotes.BackColor = Color.FromArgb(255, 100, 100, 100);
                lbNotes.BackColor = Color.FromArgb(255, 100, 100, 100);
                lvReminders.BackColor = Color.FromArgb(255, 100, 100, 100);
                lvSideBarReminders.BackColor = Color.FromArgb(255, 100, 100, 100);
                rtbSideBarNoteText.BackColor = Color.FromArgb(255, 100, 100, 100);
                lbNotes.ForeColor = Color.White;
                rtbNotes.ForeColor = Color.White;
                lvReminders.ForeColor = Color.White;
                lvSideBarReminders.ForeColor = Color.White;
                flpLibrary.BackColor = Color.Black;
                ipbUserPicture.BackColor = Color.FromArgb(255, 15, 17, 16);
                ipbUserPicture.IconColor = Color.FromArgb(255,100,100,100);
                lblCurrentUser.ForeColor = Color.White;
                lvFavorites.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                rtbSideBarNoteText.ForeColor = Color.White;
                mtbNoteTitleSidebar.ForeColor = Color.White;
                rtbSideBarNoteText.BackColor = Color.FromArgb(255, 100, 100, 100);
                mtbNoteTitleSidebar.BackColor = Color.FromArgb(255, 100, 100, 100);
                mpRecentlyUsed.BackColor = Color.FromArgb(255, 100, 100, 100);
                lbRecentlyUsed.BackColor = Color.FromArgb(255, 100, 100, 100);
                lbRecentlyUsed.ForeColor = Color.White;
                ibSearch.IconColor= Color.FromArgb(255,100,100,100);
                ibSearch.BackColor = Color.FromArgb(255, 15,17,16);
                btnAddFlow.IconColor = Color.FromArgb(255, 100, 100, 100);
            }
            else
            {
                msmForm1.Theme = MetroFramework.MetroThemeStyle.Light;
                panelFavorites.BackColor = Color.FromArgb(255, 240, 240, 240);
                panel2.BackColor = Color.FromArgb(255, 240, 240, 240);
                panel3.BackColor = Color.FromArgb(255, 240, 240, 240);
                ibDarkMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
                lvFavorites.BackColor = Color.White;
                rtbNotes.BackColor = Color.White;
                lbNotes.BackColor = Color.White;
                lvReminders.BackColor = Color.White;
                lvSideBarReminders.BackColor = Color.White;
                rtbSideBarNoteText.BackColor = Color.White;
                lbNotes.ForeColor = Color.Black;
                rtbNotes.ForeColor = Color.Black;
                lvReminders.ForeColor = Color.Black;
                lvSideBarReminders.ForeColor = Color.Black;
                flpLibrary.BackColor = Color.FromArgb(255, 240, 240, 240);
                ipbUserPicture.BackColor = Color.White;
                ipbUserPicture.IconColor = Color.Black;
                lblCurrentUser.ForeColor = Color.Black;
                lvFavorites.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                rtbSideBarNoteText.ForeColor = Color.Black;
                mtbNoteTitleSidebar.ForeColor = Color.Black;
                rtbSideBarNoteText.BackColor = Color.White;
                mtbNoteTitleSidebar.BackColor = Color.White;
                mpRecentlyUsed.BackColor = Color.White;
                lbRecentlyUsed.BackColor = Color.White;
                lbRecentlyUsed.ForeColor = Color.Black;
                ibSearch.IconColor = Color.Black;
                ibSearch.BackColor = Color.White;
                btnAddFlow.IconColor = Color.Black;
            }

        }

        private void lvFavorites_MouseDoubleClick(object sender, MouseEventArgs e) {
            if( e.Button == MouseButtons.Left ) {
                if( lvFavorites.SelectedItems.Count > 0 ) {
                    ListViewItem i = lvFavorites.SelectedItems[0];
                    App app = i.Tag as App;
                    if( app != null ) {
                        app.Launch();
                    }
                }
            }
        }

        private void ibRemoveFavorite_Click(object sender, EventArgs e) {
            if( lvFavorites.SelectedItems.Count > 0 ) {
                ListViewItem i = lvFavorites.SelectedItems[0];
                App app = i.Tag as App;
                if( app != null ) {
                    Apps.RemoveFavorite(app);
                    lvFavorites.Items.Remove(i);
                }
            }
        }

        private void lbRecentlyUsed_MouseDoubleClick(object sender, EventArgs e) {
            if( lbRecentlyUsed.SelectedIndex != -1 ) {
                App app = lbRecentlyUsed.SelectedItem as App;
                if( app != null ) {
                    app.Launch();
                }
            }
        }

        private void mtbSearch_TextChanged(object sender, EventArgs e) {
            if( mtbSearch.Text == string.Empty ) {
                foreach( AppUserControl uc in flpLibrary.Controls ) {
                    uc.Visible = true;
                }
                return;
            }
            foreach(AppUserControl uc in flpLibrary.Controls ) {
                  if( uc.MainApp.Name.ToLower().Contains(mtbSearch.Text.ToLower()) ) {
                    uc.Visible = true;
                } else {
                    uc.Visible = false;
                }
            }
        }

    }
}
        
    
