using System;

namespace Universal_Launcher {
    [Serializable]
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
            this.lblAppName = new MetroFramework.Controls.MetroLabel();
            this.flpSubApps = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.cbAddSubApp = new MetroFramework.Controls.MetroComboBox();
            this.tbChangeName = new MetroFramework.Controls.MetroTextBox();
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
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(60, 3);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(81, 19);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "metroLabel1";
            this.lblAppName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAppName_MouseDoubleClick);
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
            // btnDel
            // 
            this.btnDel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDel.Location = new System.Drawing.Point(275, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(22, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "-";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.tbChangeName.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.tbChangeName.CustomButton.Name = "";
            this.tbChangeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbChangeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbChangeName.CustomButton.TabIndex = 1;
            this.tbChangeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbChangeName.CustomButton.UseSelectable = true;
            this.tbChangeName.CustomButton.Visible = false;
            this.tbChangeName.Enabled = false;
            this.tbChangeName.Lines = new string[0];
            this.tbChangeName.Location = new System.Drawing.Point(61, 26);
            this.tbChangeName.MaxLength = 32767;
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.PasswordChar = '\0';
            this.tbChangeName.PromptText = "Change name";
            this.tbChangeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChangeName.SelectedText = "";
            this.tbChangeName.SelectionLength = 0;
            this.tbChangeName.SelectionStart = 0;
            this.tbChangeName.ShortcutsEnabled = true;
            this.tbChangeName.Size = new System.Drawing.Size(88, 23);
            this.tbChangeName.TabIndex = 8;
            this.tbChangeName.UseSelectable = true;
            this.tbChangeName.Visible = false;
            this.tbChangeName.WaterMark = "Change name";
            this.tbChangeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChangeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbChangeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangeName_KeyDown);
            // 
            // AppUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbChangeName);
            this.Controls.Add(this.cbAddSubApp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.flpSubApps);
            this.Controls.Add(this.pbAppIcon);
            this.Controls.Add(this.lblAppName);
            this.Name = "AppUserControl";
            this.Size = new System.Drawing.Size(300, 338);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAppIcon;
        private MetroFramework.Controls.MetroLabel lblAppName;
        private System.Windows.Forms.FlowLayoutPanel flpSubApps;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroComboBox cbAddSubApp;
        private MetroFramework.Controls.MetroTextBox tbChangeName;
    }
}
