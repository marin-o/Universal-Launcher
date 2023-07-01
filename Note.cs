using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public Note() { }
        public Note(string title, string text) { Title = title; Text = text;}

        public override string ToString()
        {
            return string.Format("{0}",Title);
        }

        
    }
}
