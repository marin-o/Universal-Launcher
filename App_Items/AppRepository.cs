using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    [Serializable]
    public class AppRepository { 
        public List<App> Apps { get; set; } = new List<App>();

        public void AddApp(App app) {
            Apps.Add(app);
        }
        public void RemoveApp(App app) {
            Apps.Remove(app);
        }
    }
}
