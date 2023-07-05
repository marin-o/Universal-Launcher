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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbTask
            // 
            // 
            // 
            // 
            this.mtbTask.CustomButton.Image = null;
            this.mtbTask.CustomButton.Location = new System.Drawing.Point(455, 2);
            this.mtbTask.CustomButton.Name = "";
            this.mtbTask.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.mtbTask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTask.CustomButton.TabIndex = 1;
            this.mtbTask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTask.CustomButton.UseSelectable = true;
            this.mtbTask.CustomButton.Visible = false;
            this.mtbTask.Lines = new string[0];
            this.mtbTask.Location = new System.Drawing.Point(23, 70);
            this.mtbTask.MaxLength = 32767;
            this.mtbTask.Name = "mtbTask";
            this.mtbTask.PasswordChar = '\0';
            this.mtbTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTask.SelectedText = "";
            this.mtbTask.SelectionLength = 0;
            this.mtbTask.SelectionStart = 0;
            this.mtbTask.ShortcutsEnabled = true;
            this.mtbTask.Size = new System.Drawing.Size(487, 34);
            this.mtbTask.TabIndex = 0;
            this.mtbTask.UseSelectable = true;
            this.mtbTask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbTask.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTask_Validating);
            // 
            // DtReminder
            // 
            this.DtReminder.Location = new System.Drawing.Point(310, 126);
            this.DtReminder.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtReminder.Name = "DtReminder";
            this.DtReminder.Size = new System.Drawing.Size(200, 30);
            this.DtReminder.TabIndex = 1;
            this.DtReminder.Validating += new System.ComponentModel.CancelEventHandler(this.DtReminder_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(136, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(184, 31);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // NewReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtReminder);
            this.Controls.Add(this.mtbTask);
            this.Name = "NewReminder";
            this.Text = "NewReminder";
            this.Load += new System.EventHandler(this.NewReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbTask;
        private MetroFramework.Controls.MetroDateTime DtReminder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}