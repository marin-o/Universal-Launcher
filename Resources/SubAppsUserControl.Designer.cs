namespace Universal_Launcher.Resources {
    partial class SubAppsUserControl {
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.tbChangeName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.Location = new System.Drawing.Point(3, 3);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.Size = new System.Drawing.Size(51, 44);
            this.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAppIcon.TabIndex = 7;
            this.pbAppIcon.TabStop = false;
            this.pbAppIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbAppIcon_MouseDoubleClick);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(60, 13);
            this.lblAppName.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(176, 34);
            this.lblAppName.TabIndex = 10;
            this.lblAppName.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lblAppName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAppName_MouseDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.IconSize = 25;
            this.btnRemove.Location = new System.Drawing.Point(242, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.tbChangeName.Location = new System.Drawing.Point(180, 27);
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
            this.tbChangeName.TabIndex = 12;
            this.tbChangeName.UseSelectable = true;
            this.tbChangeName.Visible = false;
            this.tbChangeName.WaterMark = "Change name";
            this.tbChangeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChangeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbChangeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangeName_KeyDown);
            // 
            // SubAppsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.tbChangeName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.pbAppIcon);
            this.Name = "SubAppsUserControl";
            this.Size = new System.Drawing.Size(269, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAppIcon;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnRemove;
        private MetroFramework.Controls.MetroTextBox tbChangeName;
    }
}
