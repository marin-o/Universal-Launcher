using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.AppClasses {
    public static class AppUtilities {
        public static bool CheckPath(string filePath) {
            if( System.IO.File.Exists(filePath) ) {
                return true;
            }
            return false;
        }
    }
}
