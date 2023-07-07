namespace Universal_Launcher
{
    partial class CreateNote
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
            this.mtbNote = new MetroFramework.Controls.MetroTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtbTitle = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mtbNote
            // 
            // 
            // 
            // 
            this.mtbNote.CustomButton.Image = null;
            this.mtbNote.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.mtbNote.CustomButton.Name = "";
            this.mtbNote.CustomButton.Size = new System.Drawing.Size(193, 193);
            this.mtbNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNote.CustomButton.TabIndex = 1;
            this.mtbNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNote.CustomButton.UseSelectable = true;
            this.mtbNote.CustomButton.Visible = false;
            this.mtbNote.Lines = new string[0];
            this.mtbNote.Location = new System.Drawing.Point(19, 86);
            this.mtbNote.MaxLength = 32767;
            this.mtbNote.Multiline = true;
            this.mtbNote.Name = "mtbNote";
            this.mtbNote.PasswordChar = '\0';
            this.mtbNote.WaterMark = "Text:";
            this.mtbNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNote.SelectedText = "";
            this.mtbNote.SelectionLength = 0;
            this.mtbNote.SelectionStart = 0;
            this.mtbNote.ShortcutsEnabled = true;
            this.mtbNote.Size = new System.Drawing.Size(310, 195);
            this.mtbNote.TabIndex = 1;
            this.mtbNote.UseSelectable = true;
            this.mtbNote.WaterMark = "Text:";
            this.mtbNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(19, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(156, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtbTitle
            // 
            // 
            // 
            // 
            this.mtbTitle.CustomButton.Image = null;
            this.mtbTitle.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.mtbTitle.CustomButton.Name = "";
            this.mtbTitle.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtbTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTitle.CustomButton.TabIndex = 1;
            this.mtbTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTitle.CustomButton.UseSelectable = true;
            this.mtbTitle.CustomButton.Visible = false;
            this.mtbTitle.Lines = new string[0];
            this.mtbTitle.Location = new System.Drawing.Point(19, 56);
            this.mtbTitle.MaxLength = 32767;
            this.mtbTitle.Name = "mtbTitle";
            this.mtbTitle.PasswordChar = '\0';
            this.mtbTitle.WaterMark = "Title:";
            this.mtbTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTitle.SelectedText = "";
            this.mtbTitle.SelectionLength = 0;
            this.mtbTitle.SelectionStart = 0;
            this.mtbTitle.ShortcutsEnabled = true;
            this.mtbTitle.Size = new System.Drawing.Size(310, 21);
            this.mtbTitle.TabIndex = 0;
            this.mtbTitle.UseSelectable = true;
            this.mtbTitle.WaterMark = "Title:";
            this.mtbTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 315);
            this.Controls.Add(this.mtbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mtbNote);
            this.Name = "CreateNote";
            this.Resizable = false;
            this.Text = "Create Note";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private MetroFramework.Controls.MetroTextBox mtbTitle;
        internal MetroFramework.Controls.MetroTextBox mtbNote;
    }
}