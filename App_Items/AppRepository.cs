using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    [Serializable]
    public class AppRepository { 
        public List<AppUserControl> Apps { get; set; } = new List<AppUserControl>();

        internal void AddApp(AppUserControl uc) {
            Apps.Add(uc);
        }
    }
}
