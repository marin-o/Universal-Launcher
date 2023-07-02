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
        public string Body { get; set; }

        public Note() {
            Title = "Empty note";

        }
        public Note(string title, string body) { 
            if(title == string.Empty)
                Title = $"Note {DateTime.Now.ToString("dd/MM/yyyy")}";
            else Title = title;
            Body = body;
        }

        public override string ToString()
        {
            return string.Format("{0}",Title);
        }

        
    }
}
