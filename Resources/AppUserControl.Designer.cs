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
            this.lblAppName = new MetroFramework.Controls.MetroLabel();
            this.flpSubApps = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnAddSubApp = new System.Windows.Forms.Button();
            this.cbAddSubApp = new MetroFramework.Controls.MetroComboBox();
            this.lblAdd = new System.Windows.Forms.Label();
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
            // 
            // flpSubApps
            // 
            this.flpSubApps.AutoScroll = true;
            this.flpSubApps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSubApps.Location = new System.Drawing.Point(3, 51);
            this.flpSubApps.Name = "flpSubApps";
            this.flpSubApps.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flpSubApps.Size = new System.Drawing.Size(294, 311);
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
            // btnAddSubApp
            // 
            this.btnAddSubApp.Location = new System.Drawing.Point(60, 25);
            this.btnAddSubApp.Name = "btnAddSubApp";
            this.btnAddSubApp.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubApp.TabIndex = 6;
            this.btnAddSubApp.Text = "Add";
            this.btnAddSubApp.UseVisualStyleBackColor = true;
            this.btnAddSubApp.Click += new System.EventHandler(this.btnAddSubApp_Click);
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
            this.cbAddSubApp.Size = new System.Drawing.Size(79, 29);
            this.cbAddSubApp.TabIndex = 7;
            this.cbAddSubApp.UseSelectable = true;
            this.cbAddSubApp.SelectedIndexChanged += new System.EventHandler(this.cbAddSubApp_SelectedIndexChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.White;
            this.lblAdd.Enabled = false;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(195, 9);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(33, 17);
            this.lblAdd.TabIndex = 8;
            this.lblAdd.Text = "Add";
            // 
            // AppUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.cbAddSubApp);
            this.Controls.Add(this.btnAddSubApp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.flpSubApps);
            this.Controls.Add(this.pbAppIcon);
            this.Controls.Add(this.lblAppName);
            this.Name = "AppUserControl";
            this.Size = new System.Drawing.Size(300, 365);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAppIcon;
        private MetroFramework.Controls.MetroLabel lblAppName;
        private System.Windows.Forms.FlowLayoutPanel flpSubApps;
        private MetroFramework.Controls.MetroButton btnDel;
        private System.Windows.Forms.Button btnAddSubApp;
        private MetroFramework.Controls.MetroComboBox cbAddSubApp;
        private System.Windows.Forms.Label lblAdd;
    }
}
