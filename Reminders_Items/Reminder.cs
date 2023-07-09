using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.Reminders_Items
{
    [Serializable]
    public class Reminder
    {
        public string Task { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsChecked { get; set; } = false;
        public Reminder(string task, DateTime dateTime)
        {
            Task = task;
            DateTime = dateTime;
        }

        public Reminder()
        {
        }

        public string GetDate() {
            return DateTime.ToShortDateString();
        }

        public override string ToString()
        {
            string date = DateTime.ToShortDateString().Remove(10);
            return $"{Task} {date}";
        }
    }
}
