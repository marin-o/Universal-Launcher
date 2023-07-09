using System;

namespace Universal_Launcher {
    partial class AppUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.flpSubApps = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAddSubApp = new MetroFramework.Controls.MetroComboBox();
            this.tbChangeName = new MetroFramework.Controls.MetroTextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.Location = new System.Drawing.Point(3, 3);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.Size = new System.Drawing.Size(51, 42);
            this.pbAppIcon.TabIndex = 2;
            this.pbAppIcon.TabStop = false;
            this.pbAppIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbAppIcon_MouseDoubleClick);
            // 
            // flpSubApps
            // 
            this.flpSubApps.AutoScroll = true;
            this.flpSubApps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSubApps.Location = new System.Drawing.Point(3, 51);
            this.flpSubApps.Name = "flpSubApps";
            this.flpSubApps.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flpSubApps.Size = new System.Drawing.Size(294, 284);
            this.flpSubApps.TabIndex = 4;
            this.flpSubApps.WrapContents = false;
            // 
            // cbAddSubApp
            // 
            this.cbAddSubApp.DisplayMember = "Add";
            this.cbAddSubApp.FormattingEnabled = true;
            this.cbAddSubApp.ItemHeight = 23;
            this.cbAddSubApp.Items.AddRange(new object[] {
            "Add",
            "App",
            "Project"});
            this.cbAddSubApp.Location = new System.Drawing.Point(193, 3);
            this.cbAddSubApp.Name = "cbAddSubApp";
            this.cbAddSubApp.Size = new System.Drawing.Size(79, 29);
            this.cbAddSubApp.TabIndex = 7;
            this.cbAddSubApp.UseSelectable = true;
            this.cbAddSubApp.SelectedIndexChanged += new System.EventHandler(this.cbAddSubApp_SelectedIndexChanged);
            // 
            // tbChangeName
            // 
            // 
            // 
            // 
            this.tbChangeName.CustomButton.Image = null;
            this.tbChangeName.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.tbChangeName.CustomButton.Name = "";
            this.tbChangeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbChangeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbChangeName.CustomButton.TabIndex = 1;
            this.tbChangeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbChangeName.CustomButton.UseSelectable = true;
            this.tbChangeName.CustomButton.Visible = false;
            this.tbChangeName.Enabled = false;
            this.tbChangeName.Lines = new string[0];
            this.tbChangeName.Location = new System.Drawing.Point(63, 26);
            this.tbChangeName.MaxLength = 32767;
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.PasswordChar = '\0';
            this.tbChangeName.PromptText = "Change name";
            this.tbChangeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChangeName.SelectedText = "";
            this.tbChangeName.SelectionLength = 0;
            this.tbChangeName.SelectionStart = 0;
            this.tbChangeName.ShortcutsEnabled = true;
            this.tbChangeName.Size = new System.Drawing.Size(86, 23);
            this.tbChangeName.TabIndex = 8;
            this.tbChangeName.UseSelectable = true;
            this.tbChangeName.Visible = false;
            this.tbChangeName.WaterMark = "Change name";
            this.tbChangeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChangeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbChangeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangeName_KeyDown);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(60, 6);
            this.lblAppName.MaximumSize = new System.Drawing.Size(120, 20);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(120, 20);
            this.lblAppName.TabIndex = 9;
            this.lblAppName.Text = "aaaaaaaaaaaaaaaaaaaaaa";
            this.lblAppName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAppName_MouseDoubleClick);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDel.IconSize = 25;
            this.btnDel.Location = new System.Drawing.Point(278, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(19, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnFavorite.IconColor = System.Drawing.Color.Black;
            this.btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFavorite.IconSize = 25;
            this.btnFavorite.Location = new System.Drawing.Point(278, 26);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(19, 23);
            this.btnFavorite.TabIndex = 11;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // AppUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.tbChangeName);
            this.Controls.Add(this.cbAddSubApp);
            this.Controls.Add(this.flpSubApps);
            this.Controls.Add(this.pbAppIcon);
            this.Name = "AppUserControl";
            this.Size = new System.Drawing.Size(300, 338);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAppIcon;
        private System.Windows.Forms.FlowLayoutPanel flpSubApps;
        private MetroFramework.Controls.MetroComboBox cbAddSubApp;
        private MetroFramework.Controls.MetroTextBox tbChangeName;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnFavorite;
    }
}
