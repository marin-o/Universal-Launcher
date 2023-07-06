using System;
using System.Collections.Generic;

namespace Universal_Launcher.App_Items {
    [Serializable]
    public class MainApp : App {
        public List<App> SubApps { get; set; } = new List<App>();
        public MainApp(string name, string path, string iconPath, System.Drawing.Icon icon) : base(name, path, iconPath, icon) { }
        public override void Launch() {
            System.Diagnostics.Process.Start(Path);
        }
        public void AddApp(App app) {
            SubApps.Add(app);
        }
    }
}
