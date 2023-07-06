using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.Notes_Items {
    [Serializable]
    public class NotesRepository {
        public List<Note> Notes { get; set; } = new List<Note>();
        public void Add(Note note) {
            Notes.Add(note);
        }

        public void Remove(Note note) {
            Notes.Remove(note);
        }
    }
}
