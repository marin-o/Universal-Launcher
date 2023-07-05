using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Launcher.AppClasses {
    
    public static class AppUtilities {
        public static bool CheckPath(string filePath) {
            if( System.IO.File.Exists(filePath) ) {
                return true;
            }
            return false;
        }
        public static string GetTargetPath(string shortcutPath) {
            string targetPath = string.Empty;
            if( CheckPath(shortcutPath) ) {
                
            }
            return targetPath;
        }
        public static ShortcutInfo GetShortcutInfo(string path) {
            string filename = Path.GetFileNameWithoutExtension(path);
            Icon icon;
            string iconPath;

            if( Path.GetExtension(path).Equals(".lnk", StringComparison.OrdinalIgnoreCase) ) {
                IWshShell shell = new WshShell();
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path);
                iconPath = link.IconLocation;

                Icon extractedIcon = Icon.ExtractAssociatedIcon(iconPath);
                icon = new Icon(extractedIcon, SystemInformation.SmallIconSize);


            }
            else {
                iconPath = path;
                icon = Icon.ExtractAssociatedIcon(path);
            }
            return new ShortcutInfo(filename, path, iconPath, icon);
        }
    }

    public class ShortcutInfo{
        public string Name { get; }
        public string FilePath { get; }
        public string IconPath { get; }
        public Icon Icon { get; }

        public ShortcutInfo(string name, string path, string iconPath, Icon icon ) {
            Name = name;
            FilePath = path;
            IconPath = iconPath;
            Icon = icon;
        }
    }

}
