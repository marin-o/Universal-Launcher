﻿using MetroFramework.Forms;
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
            lvReminders.Items.Add("test");
            lvReminders.Items[0].SubItems.Add("test2");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            if (notes.ShowDialog() == DialogResult.OK)
            {
                lbNotes.Items.Add(notes.note);
            }
        }

        private void btnRemoveNotes_Click(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                lbNotes.Items.RemoveAt(lbNotes.SelectedIndex);
            }
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            if(activeNote != null)
            {
                activeNote.Text = rtbNotes.Text;
            }
        }

        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbNotes.SelectedIndex != -1)
            {
                activeNote = lbNotes.SelectedItem as Note;
                if(activeNote != null)
                {
                    rtbNotes.Text = activeNote.Text;
                }
            }
        }

        private void lvReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
