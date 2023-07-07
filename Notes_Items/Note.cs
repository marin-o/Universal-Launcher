using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Universal_Launcher
{
    [Serializable]
    public class Note
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Pinned { get; set; }

        public Note(string title, string body) {
            if( title == string.Empty && body == string.Empty )
                Title = "Empty note";
            else if( title == string.Empty )
                Title = $"Note {DateTime.Now.ToString("dd/MM/yyyy")}";
            else Title = title;
            Body = body;
        }

        public override string ToString()
        {
            if (Pinned)
            {
                return $"{Title} - Pinned"; // worst case scenario
            }
            else
            {
                return string.Format("{0}", Title);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Note note = obj as Note;
            if (note == null)
            {
                return false;
            }
            return this.Title == note.Title;
        }
    }
}
