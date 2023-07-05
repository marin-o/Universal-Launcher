namespace Universal_Launcher {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.lvReminders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnRemoveNotes = new System.Windows.Forms.Button();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Home);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 66);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1068, 492);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.metroLabel1);
            this.Home.Controls.Add(this.metroLabel3);
            this.Home.Controls.Add(this.metroLabel2);
            this.Home.Controls.Add(this.panel3);
            this.Home.Controls.Add(this.panel2);
            this.Home.Controls.Add(this.panelFavorites);
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.HorizontalScrollbarHighlightOnWheel = false;
            this.Home.HorizontalScrollbarSize = 12;
            this.Home.Location = new System.Drawing.Point(4, 38);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1060, 450);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.VerticalScrollbarBarColor = true;
            this.Home.VerticalScrollbarHighlightOnWheel = false;
            this.Home.VerticalScrollbarSize = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 1);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Favorites";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(544, 217);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Reminders";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(544, 0);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Notes";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddReminder);
            this.panel3.Controls.Add(this.lvReminders);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel3.Location = new System.Drawing.Point(544, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 193);
            this.panel3.TabIndex = 4;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(348, 161);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(139, 28);
            this.btnAddReminder.TabIndex = 4;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // lvReminders
            // 
            this.lvReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvReminders.HideSelection = false;
            this.lvReminders.Location = new System.Drawing.Point(27, 20);
            this.lvReminders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvReminders.Name = "lvReminders";
            this.lvReminders.Size = new System.Drawing.Size(459, 138);
            this.lvReminders.TabIndex = 0;
            this.lvReminders.UseCompatibleStateImageBehavior = false;
            this.lvReminders.View = System.Windows.Forms.View.Details;
            this.lvReminders.SelectedIndexChanged += new System.EventHandler(this.lvReminders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task";
            this.columnHeader2.Width = 213;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 81;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Controls.Add(this.btnRemoveNotes);
            this.panel2.Controls.Add(this.lbNotes);
            this.panel2.Controls.Add(this.rtbNotes);
            this.panel2.Location = new System.Drawing.Point(544, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 185);
            this.panel2.TabIndex = 3;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(201, 153);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(139, 28);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnRemoveNotes
            // 
            this.btnRemoveNotes.Location = new System.Drawing.Point(348, 153);
            this.btnRemoveNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveNotes.Name = "btnRemoveNotes";
            this.btnRemoveNotes.Size = new System.Drawing.Size(139, 28);
            this.btnRemoveNotes.TabIndex = 2;
            this.btnRemoveNotes.Text = "Remove";
            this.btnRemoveNotes.UseVisualStyleBackColor = true;
            this.btnRemoveNotes.Click += new System.EventHandler(this.btnRemoveNotes_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.ItemHeight = 16;
            this.lbNotes.Location = new System.Drawing.Point(201, 28);
            this.lbNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(284, 116);
            this.lbNotes.TabIndex = 1;
            this.lbNotes.SelectedIndexChanged += new System.EventHandler(this.lbNotes_SelectedIndexChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(27, 28);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(149, 127);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // panelFavorites
            // 
            this.panelFavorites.Controls.Add(this.listView1);
            this.panelFavorites.Location = new System.Drawing.Point(4, 28);
            this.panelFavorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(520, 409);
            this.panelFavorites.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 620);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Form1";
            this.metroTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFavorites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Home;
        private System.Windows.Forms.Panel panelFavorites;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnRemoveNotes;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.ListView lvReminders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;
    }
}

