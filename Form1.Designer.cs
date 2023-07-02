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
            this.mpSidePanel = new MetroFramework.Controls.MetroPanel();
            this.mpAccount = new MetroFramework.Controls.MetroPanel();
            this.ipbUserPicture = new FontAwesome.Sharp.IconPictureBox();
            this.mpRecentlyUsed = new MetroFramework.Controls.MetroPanel();
            this.mpReminders = new MetroFramework.Controls.MetroPanel();
            this.mpPinnedNote = new MetroFramework.Controls.MetroPanel();
            this.ibSettings = new FontAwesome.Sharp.IconButton();
            this.ibDarkMode = new FontAwesome.Sharp.IconButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.mpBottomSideBarPanell = new MetroFramework.Controls.MetroPanel();
            this.mpNotesNReminders = new MetroFramework.Controls.MetroPanel();
            this.mpSidePanel.SuspendLayout();
            this.mpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).BeginInit();
            this.mpBottomSideBarPanell.SuspendLayout();
            this.mpNotesNReminders.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpSidePanel
            // 
            this.mpSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpSidePanel.Controls.Add(this.mpBottomSideBarPanell);
            this.mpSidePanel.Controls.Add(this.mpNotesNReminders);
            this.mpSidePanel.Controls.Add(this.mpAccount);
            this.mpSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpSidePanel.HorizontalScrollbarBarColor = false;
            this.mpSidePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpSidePanel.HorizontalScrollbarSize = 10;
            this.mpSidePanel.Location = new System.Drawing.Point(20, 60);
            this.mpSidePanel.Name = "mpSidePanel";
            this.mpSidePanel.Size = new System.Drawing.Size(164, 424);
            this.mpSidePanel.Style = MetroFramework.MetroColorStyle.Black;
            this.mpSidePanel.TabIndex = 0;
            this.mpSidePanel.VerticalScrollbarBarColor = true;
            this.mpSidePanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpSidePanel.VerticalScrollbarSize = 10;
            this.mpSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpSidePanel_Paint);
            // 
            // mpAccount
            // 
            this.mpAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpAccount.Controls.Add(this.metroTextBox1);
            this.mpAccount.Controls.Add(this.ipbUserPicture);
            this.mpAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpAccount.HorizontalScrollbarBarColor = true;
            this.mpAccount.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAccount.HorizontalScrollbarSize = 10;
            this.mpAccount.Location = new System.Drawing.Point(0, 0);
            this.mpAccount.Name = "mpAccount";
            this.mpAccount.Size = new System.Drawing.Size(162, 67);
            this.mpAccount.TabIndex = 2;
            this.mpAccount.VerticalScrollbarBarColor = true;
            this.mpAccount.VerticalScrollbarHighlightOnWheel = false;
            this.mpAccount.VerticalScrollbarSize = 10;
            // 
            // ipbUserPicture
            // 
            this.ipbUserPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipbUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ipbUserPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbUserPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbUserPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ipbUserPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbUserPicture.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ipbUserPicture.IconSize = 52;
            this.ipbUserPicture.Location = new System.Drawing.Point(0, 0);
            this.ipbUserPicture.Name = "ipbUserPicture";
            this.ipbUserPicture.Size = new System.Drawing.Size(52, 65);
            this.ipbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipbUserPicture.TabIndex = 2;
            this.ipbUserPicture.TabStop = false;
            // 
            // mpRecentlyUsed
            // 
            this.mpRecentlyUsed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpRecentlyUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpRecentlyUsed.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpRecentlyUsed.HorizontalScrollbarBarColor = true;
            this.mpRecentlyUsed.HorizontalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.HorizontalScrollbarSize = 10;
            this.mpRecentlyUsed.Location = new System.Drawing.Point(0, 0);
            this.mpRecentlyUsed.Name = "mpRecentlyUsed";
            this.mpRecentlyUsed.Size = new System.Drawing.Size(162, 89);
            this.mpRecentlyUsed.TabIndex = 1;
            this.mpRecentlyUsed.VerticalScrollbarBarColor = true;
            this.mpRecentlyUsed.VerticalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.VerticalScrollbarSize = 10;
            // 
            // mpReminders
            // 
            this.mpReminders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpReminders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpReminders.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpReminders.HorizontalScrollbarBarColor = true;
            this.mpReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpReminders.HorizontalScrollbarSize = 10;
            this.mpReminders.Location = new System.Drawing.Point(0, 179);
            this.mpReminders.Name = "mpReminders";
            this.mpReminders.Size = new System.Drawing.Size(162, 73);
            this.mpReminders.TabIndex = 3;
            this.mpReminders.VerticalScrollbarBarColor = true;
            this.mpReminders.VerticalScrollbarHighlightOnWheel = false;
            this.mpReminders.VerticalScrollbarSize = 10;
            // 
            // mpPinnedNote
            // 
            this.mpPinnedNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpPinnedNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpPinnedNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpPinnedNote.HorizontalScrollbarBarColor = true;
            this.mpPinnedNote.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPinnedNote.HorizontalScrollbarSize = 10;
            this.mpPinnedNote.Location = new System.Drawing.Point(0, 89);
            this.mpPinnedNote.Name = "mpPinnedNote";
            this.mpPinnedNote.Size = new System.Drawing.Size(162, 90);
            this.mpPinnedNote.TabIndex = 2;
            this.mpPinnedNote.VerticalScrollbarBarColor = true;
            this.mpPinnedNote.VerticalScrollbarHighlightOnWheel = false;
            this.mpPinnedNote.VerticalScrollbarSize = 10;
            // 
            // ibSettings
            // 
            this.ibSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibSettings.FlatAppearance.BorderSize = 0;
            this.ibSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.ibSettings.IconColor = System.Drawing.Color.Black;
            this.ibSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibSettings.IconSize = 30;
            this.ibSettings.Location = new System.Drawing.Point(130, 6);
            this.ibSettings.Name = "ibSettings";
            this.ibSettings.Size = new System.Drawing.Size(32, 28);
            this.ibSettings.TabIndex = 6;
            this.ibSettings.UseVisualStyleBackColor = true;
            // 
            // ibDarkMode
            // 
            this.ibDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibDarkMode.FlatAppearance.BorderSize = 0;
            this.ibDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDarkMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.ibDarkMode.IconColor = System.Drawing.Color.Black;
            this.ibDarkMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibDarkMode.IconSize = 25;
            this.ibDarkMode.Location = new System.Drawing.Point(-1, 8);
            this.ibDarkMode.Name = "ibDarkMode";
            this.ibDarkMode.Size = new System.Drawing.Size(32, 28);
            this.ibDarkMode.TabIndex = 7;
            this.ibDarkMode.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Enabled = false;
            this.metroTextBox1.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTextBox1.CustomButton.FlatAppearance.BorderSize = 0;
            this.metroTextBox1.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[] {
        "Username"};
            this.metroTextBox1.Location = new System.Drawing.Point(50, 7);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(103, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "Username";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mpBottomSideBarPanell
            // 
            this.mpBottomSideBarPanell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mpBottomSideBarPanell.Controls.Add(this.ibSettings);
            this.mpBottomSideBarPanell.Controls.Add(this.ibDarkMode);
            this.mpBottomSideBarPanell.HorizontalScrollbarBarColor = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarSize = 10;
            this.mpBottomSideBarPanell.Location = new System.Drawing.Point(0, 389);
            this.mpBottomSideBarPanell.Name = "mpBottomSideBarPanell";
            this.mpBottomSideBarPanell.Size = new System.Drawing.Size(162, 34);
            this.mpBottomSideBarPanell.TabIndex = 8;
            this.mpBottomSideBarPanell.VerticalScrollbarBarColor = true;
            this.mpBottomSideBarPanell.VerticalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.VerticalScrollbarSize = 10;
            // 
            // mpNotesNReminders
            // 
            this.mpNotesNReminders.AutoScroll = true;
            this.mpNotesNReminders.Controls.Add(this.mpReminders);
            this.mpNotesNReminders.Controls.Add(this.mpPinnedNote);
            this.mpNotesNReminders.Controls.Add(this.mpRecentlyUsed);
            this.mpNotesNReminders.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpNotesNReminders.HorizontalScrollbar = true;
            this.mpNotesNReminders.HorizontalScrollbarBarColor = true;
            this.mpNotesNReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpNotesNReminders.HorizontalScrollbarSize = 10;
            this.mpNotesNReminders.Location = new System.Drawing.Point(0, 67);
            this.mpNotesNReminders.Name = "mpNotesNReminders";
            this.mpNotesNReminders.Size = new System.Drawing.Size(162, 356);
            this.mpNotesNReminders.TabIndex = 9;
            this.mpNotesNReminders.VerticalScrollbar = true;
            this.mpNotesNReminders.VerticalScrollbarBarColor = true;
            this.mpNotesNReminders.VerticalScrollbarHighlightOnWheel = false;
            this.mpNotesNReminders.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 504);
            this.Controls.Add(this.mpSidePanel);
            this.MinimumSize = new System.Drawing.Size(1036, 504);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mpSidePanel.ResumeLayout(false);
            this.mpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).EndInit();
            this.mpBottomSideBarPanell.ResumeLayout(false);
            this.mpNotesNReminders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpSidePanel;
        private MetroFramework.Controls.MetroPanel mpAccount;
        private FontAwesome.Sharp.IconPictureBox ipbUserPicture;
        private MetroFramework.Controls.MetroPanel mpPinnedNote;
        private MetroFramework.Controls.MetroPanel mpReminders;
        private MetroFramework.Controls.MetroPanel mpRecentlyUsed;
        private FontAwesome.Sharp.IconButton ibSettings;
        private FontAwesome.Sharp.IconButton ibDarkMode;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroPanel mpBottomSideBarPanell;
        private MetroFramework.Controls.MetroPanel mpNotesNReminders;
    }
}

