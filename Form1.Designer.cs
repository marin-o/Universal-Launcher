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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpTestChildren = new MetroFramework.Controls.MetroTabPage();
            this.flpLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFlow = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tpTestChildren.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tpTestChildren);
            this.metroTabControl1.Location = new System.Drawing.Point(204, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(801, 418);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpTestChildren
            // 
            this.tpTestChildren.Controls.Add(this.flpLibrary);
            this.tpTestChildren.HorizontalScrollbarBarColor = true;
            this.tpTestChildren.HorizontalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.HorizontalScrollbarSize = 10;
            this.tpTestChildren.Location = new System.Drawing.Point(4, 38);
            this.tpTestChildren.Name = "tpTestChildren";
            this.tpTestChildren.Size = new System.Drawing.Size(793, 376);
            this.tpTestChildren.TabIndex = 1;
            this.tpTestChildren.Text = "Library";
            this.tpTestChildren.VerticalScrollbarBarColor = true;
            this.tpTestChildren.VerticalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.VerticalScrollbarSize = 10;
            // 
            // flpLibrary
            // 
            this.flpLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLibrary.AutoScroll = true;
            this.flpLibrary.Location = new System.Drawing.Point(0, 0);
            this.flpLibrary.Name = "flpLibrary";
            this.flpLibrary.Size = new System.Drawing.Size(793, 376);
            this.flpLibrary.TabIndex = 4;
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFlow.Location = new System.Drawing.Point(822, 34);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(75, 23);
            this.btnAddFlow.TabIndex = 1;
            this.btnAddFlow.Text = "add";
            this.btnAddFlow.UseSelectable = true;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(928, 34);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 504);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFlow);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(1036, 504);
            this.Name = "Form1";
            this.Text = "Form1";
            this.metroTabControl1.ResumeLayout(false);
            this.tpTestChildren.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpTestChildren;
        private MetroFramework.Controls.MetroButton btnAddFlow;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.FlowLayoutPanel flpLibrary;
    }
}

