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

namespace Universal_Launcher.App_Items {
    
    public static class AppUtilities {
        private static IAppFactory mainAppFactory = new MainAppFactory();
        private static IAppFactory subAppFactory = new SubAppFactory();
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
        public static AppInfo GetAppInfo(string path) {
            if( !CheckPath(path) ) {
                throw new AppDoesNotExistException("The requested app does not exist or could not be found.");
            }
            string filename = Path.GetFileNameWithoutExtension(path);
            Icon icon;
            string iconPath;
            SubAppType type = SubAppType.None;

            if( Path.GetExtension(path).Equals(".lnk", StringComparison.OrdinalIgnoreCase) ) {
                IWshShell shell = new WshShell();
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path);
                iconPath = link.IconLocation;

                Icon extractedIcon = Icon.ExtractAssociatedIcon(iconPath);
                icon = new Icon(extractedIcon, SystemInformation.SmallIconSize);
                type = SubAppType.Web;
            }
            else {
                iconPath = path;
                icon = Icon.ExtractAssociatedIcon(path);
                type = SubAppType.Executable;
            }
            return new AppInfo(filename, path, iconPath, icon, type);
        }

        public static App GetMainApp(AppInfo info) {
            return mainAppFactory.CreateApp(info.Name, info.FilePath, info.IconPath, info.Icon, SubAppType.None, null);
        }

        public static App GetSubApp(AppInfo info) {
            return subAppFactory.CreateApp(info.Name, info.FilePath, info.IconPath, info.Icon, info.Type, null);
        }
    }

    public class AppInfo{
        public string Name { get; }
        public string FilePath { get; }
        public string IconPath { get; }
        public Icon Icon { get; }
        public SubAppType Type { get; } = SubAppType.None;

        public AppInfo(string name, string path, string iconPath, Icon icon, SubAppType type) {
            Name = name;
            FilePath = path;
            IconPath = iconPath;
            Icon = icon;
            Type = type;
        }
    }

}
