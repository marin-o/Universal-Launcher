using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.AppClasses {
    public interface IAppFactory {
        App CreateApp(string name, string path, Icon icon); //todo other app types
    }
}
