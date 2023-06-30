namespace Universal_Launcher {
    partial class ucTest {
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
            this.flSubApps = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDel = new MetroFramework.Controls.MetroButton();
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
            // flSubApps
            // 
            this.flSubApps.Location = new System.Drawing.Point(3, 51);
            this.flSubApps.Name = "flSubApps";
            this.flSubApps.Size = new System.Drawing.Size(294, 109);
            this.flSubApps.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDel.Location = new System.Drawing.Point(274, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(22, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "-";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ucTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.flSubApps);
            this.Controls.Add(this.pbAppIcon);
            this.Controls.Add(this.lblAppName);
            this.Name = "ucTest";
            this.Size = new System.Drawing.Size(300, 163);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAppIcon;
        private MetroFramework.Controls.MetroLabel lblAppName;
        private System.Windows.Forms.FlowLayoutPanel flSubApps;
        private MetroFramework.Controls.MetroButton btnDel;
    }
}
