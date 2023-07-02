using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Universal_Launcher {
    public partial class Form1 : MetroForm {

        private Note activeNote = null;
        public Form1() {
            InitializeComponent();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            CreateNote notes = new CreateNote();
            if (notes.ShowDialog() == DialogResult.OK)
            {
                lbNotes.Items.Add(notes.Note);
            }
        }

        private void btnRemoveNotes_Click(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                lbNotes.Items.RemoveAt(lbNotes.SelectedIndex);
                rtbNotes.Text = "";
            }
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            if(activeNote != null)
            {
                activeNote.Body = rtbNotes.Text;
            }
        }

        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                activeNote = lbNotes.SelectedItem as Note;
                if(activeNote != null)
                {
                    rtbNotes.Text = activeNote.Body;
                }
            }
        }
    }
}
