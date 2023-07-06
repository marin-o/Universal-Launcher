using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher
{
    [Serializable]
    public class RemindersRepository
    {
        public List<Reminder> Reminders { get; set; } = new List<Reminder>();
        public void AddReminder(Reminder reminder)
        {
            Reminders.Add(reminder);
        }

    }
}
