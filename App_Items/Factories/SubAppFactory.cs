using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    public class SubAppFactory : IAppFactory {
        public App CreateApp(string name, string path, string iconPath, Icon icon, SubAppType type, App parent) {
            return new SubApp(name, path, iconPath, icon, type, parent);
        }
    }
}
