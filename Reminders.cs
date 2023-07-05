using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher
{
    public class Reminders
    {
        public List<Reminder> reminders { get; set; } = new List<Reminder>();

        public Reminders() { }

        public void AddReminder(Reminder reminder)
        {
            reminders.Add(reminder);
        }

    }
}
