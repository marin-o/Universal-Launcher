using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    public interface IAppFactory {
        App CreateApp(string name, string path, string iconPath, Icon icon, SubAppType type = SubAppType.None, App parent = null);
    }
}
