using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.Notes_Items {
    [Serializable]
    public class NotesRepository {
        public List<Note> Notes { get; set; } = new List<Note>();

        private Note pinnedNote = null;
        public Note PinnedNote { get { return pinnedNote; } }
        public void Add(Note note) {
            Notes.Add(note);
        }

        public void Remove(Note note) {
            if(note.Equals(pinnedNote) ) {
                pinnedNote = null;
            }
            Notes.Remove(note);
        }

        public void PinNote(Note note)
        {
            foreach( Note n in Notes ) {
                if( n.Equals(note) ) {
                    n.IsPinned = true;
                    pinnedNote = n;
                }
                else {
                    n.IsPinned = false;
                }
            }
        }
    }
}
