using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.AppClasses {
    public class MainApp : App {
        public List<App> SubApps { get; set; } = new List<App>();
        public MainApp(string name, string path, System.Drawing.Icon icon) : base(name, path, icon) { }
        public override void Launch() {
            System.Diagnostics.Process.Start(Path);
        }
    }
}
