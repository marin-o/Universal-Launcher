using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.AppClasses {
    public class MainAppFactory : IAppFactory{
        public App CreateApp(string name, string path, System.Drawing.Icon icon) {
            if( AppUtilities.CheckPath(path) ) {
                return new MainApp(name, path, icon);
            }
            else {
                throw new AppDoesNotExistException("The requested app does not exist.");
            }
        }
    }
}
