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
            this.tbChangeNameOrCategory = new MetroFramework.Controls.MetroTextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.ibChangeCategory = new FontAwesome.Sharp.IconButton();
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
            this.flpSubApps.Location = new System.Drawing.Point(3, 71);
            this.flpSubApps.Name = "flpSubApps";
            this.flpSubApps.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flpSubApps.Size = new System.Drawing.Size(294, 264);
            this.flpSubApps.TabIndex = 4;
            this.flpSubApps.WrapContents = false;
            // 
            // cbAddSubApp
            // 
            this.cbAddSubApp.DisplayMember = "Add";
            this.cbAddSubApp.FormattingEnabled = true;
            this.cbAddSubApp.ItemHeight = 23;
            this.cbAddSubApp.Items.AddRange(new object[] {
            "App",
            "Project"});
            this.cbAddSubApp.Location = new System.Drawing.Point(193, 3);
            this.cbAddSubApp.Name = "cbAddSubApp";
            this.cbAddSubApp.PromptText = "Add";
            this.cbAddSubApp.Size = new System.Drawing.Size(79, 29);
            this.cbAddSubApp.TabIndex = 7;
            this.cbAddSubApp.UseSelectable = true;
            this.cbAddSubApp.SelectedIndexChanged += new System.EventHandler(this.cbAddSubApp_SelectedIndexChanged);
            // 
            // tbChangeNameOrCategory
            // 
            // 
            // 
            // 
            this.tbChangeNameOrCategory.CustomButton.Image = null;
            this.tbChangeNameOrCategory.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.tbChangeNameOrCategory.CustomButton.Name = "";
            this.tbChangeNameOrCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbChangeNameOrCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbChangeNameOrCategory.CustomButton.TabIndex = 1;
            this.tbChangeNameOrCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbChangeNameOrCategory.CustomButton.UseSelectable = true;
            this.tbChangeNameOrCategory.CustomButton.Visible = false;
            this.tbChangeNameOrCategory.Enabled = false;
            this.tbChangeNameOrCategory.Lines = new string[0];
            this.tbChangeNameOrCategory.Location = new System.Drawing.Point(63, 26);
            this.tbChangeNameOrCategory.MaxLength = 32767;
            this.tbChangeNameOrCategory.Name = "tbChangeNameOrCategory";
            this.tbChangeNameOrCategory.PasswordChar = '\0';
            this.tbChangeNameOrCategory.PromptText = "Change name";
            this.tbChangeNameOrCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChangeNameOrCategory.SelectedText = "";
            this.tbChangeNameOrCategory.SelectionLength = 0;
            this.tbChangeNameOrCategory.SelectionStart = 0;
            this.tbChangeNameOrCategory.ShortcutsEnabled = true;
            this.tbChangeNameOrCategory.Size = new System.Drawing.Size(124, 23);
            this.tbChangeNameOrCategory.TabIndex = 8;
            this.tbChangeNameOrCategory.UseSelectable = true;
            this.tbChangeNameOrCategory.Visible = false;
            this.tbChangeNameOrCategory.WaterMark = "Change name";
            this.tbChangeNameOrCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChangeNameOrCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbChangeNameOrCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangeNameOrCategory_KeyDown);
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
            // ibChangeCategory
            // 
            this.ibChangeCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibChangeCategory.FlatAppearance.BorderSize = 0;
            this.ibChangeCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibChangeCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibChangeCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibChangeCategory.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.ibChangeCategory.IconColor = System.Drawing.Color.Black;
            this.ibChangeCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibChangeCategory.IconSize = 25;
            this.ibChangeCategory.Location = new System.Drawing.Point(278, 47);
            this.ibChangeCategory.Name = "ibChangeCategory";
            this.ibChangeCategory.Size = new System.Drawing.Size(19, 23);
            this.ibChangeCategory.TabIndex = 12;
            this.ibChangeCategory.UseVisualStyleBackColor = true;
            this.ibChangeCategory.Click += new System.EventHandler(this.ibChangeCategory_Click);
            // 
            // AppUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.ibChangeCategory);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.tbChangeNameOrCategory);
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
        private MetroFramework.Controls.MetroTextBox tbChangeNameOrCategory;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private FontAwesome.Sharp.IconButton ibChangeCategory;
    }
}
