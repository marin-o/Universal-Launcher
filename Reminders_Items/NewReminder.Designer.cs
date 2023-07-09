namespace Universal_Launcher
{
    partial class NewReminder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtbTask = new MetroFramework.Controls.MetroTextBox();
            this.DtReminder = new MetroFramework.Controls.MetroDateTime();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.msmNewReminder = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmNewReminder)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbTask
            // 
            // 
            // 
            // 
            this.mtbTask.CustomButton.Image = null;
            this.mtbTask.CustomButton.Location = new System.Drawing.Point(330, 2);
            this.mtbTask.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTask.CustomButton.Name = "";
            this.mtbTask.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbTask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTask.CustomButton.TabIndex = 1;
            this.mtbTask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTask.CustomButton.UseSelectable = true;
            this.mtbTask.CustomButton.Visible = false;
            this.mtbTask.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbTask.Lines = new string[0];
            this.mtbTask.Location = new System.Drawing.Point(28, 73);
            this.mtbTask.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTask.MaxLength = 32767;
            this.mtbTask.Name = "mtbTask";
            this.mtbTask.PasswordChar = '\0';
            this.mtbTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTask.SelectedText = "";
            this.mtbTask.SelectionLength = 0;
            this.mtbTask.SelectionStart = 0;
            this.mtbTask.ShortcutsEnabled = true;
            this.mtbTask.Size = new System.Drawing.Size(356, 28);
            this.mtbTask.TabIndex = 0;
            this.mtbTask.UseCustomBackColor = true;
            this.mtbTask.UseCustomForeColor = true;
            this.mtbTask.UseSelectable = true;
            this.mtbTask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbTask.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTask_Validating);
            // 
            // DtReminder
            // 
            this.DtReminder.CausesValidation = false;
            this.DtReminder.Location = new System.Drawing.Point(202, 105);
            this.DtReminder.Margin = new System.Windows.Forms.Padding(2);
            this.DtReminder.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtReminder.Name = "DtReminder";
            this.DtReminder.Size = new System.Drawing.Size(182, 29);
            this.DtReminder.TabIndex = 1;
            this.DtReminder.Validating += new System.ComponentModel.CancelEventHandler(this.DtReminder_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // msmNewReminder
            // 
            this.msmNewReminder.Owner = null;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(109, 156);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 25);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(25, 58);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(31, 13);
            this.lblTask.TabIndex = 7;
            this.lblTask.Text = "Task";
            // 
            // NewReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 203);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.DtReminder);
            this.Controls.Add(this.mtbTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewReminder";
            this.Resizable = false;
            this.Text = "New Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmNewReminder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbTask;
        private MetroFramework.Controls.MetroDateTime DtReminder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private MetroFramework.Components.MetroStyleManager msmNewReminder;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private System.Windows.Forms.Label lblTask;
    }
}