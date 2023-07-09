using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Launcher.App_Items {
    [Serializable]
    public abstract class App {
        public Icon Icon { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Path { get; set; }
        public List<App> SubApps { get; set; }


        public App(string name, string path, string iconPath, Icon icon) {
            Name = name;
            Path = path;
            IconPath = iconPath;
            Icon = icon;
            SubApps = new List<App>();
        }
        public abstract void Launch();

        public override string ToString() {
            return $"\u2022 {Name}";
        }
    }
}
