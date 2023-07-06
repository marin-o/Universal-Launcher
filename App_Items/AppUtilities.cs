using IWshRuntimeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Universal_Launcher.App_Items {

    public static class AppUtilities {
        private static IAppFactory mainAppFactory = new MainAppFactory();
        private static IAppFactory subAppFactory = new SubAppFactory();
        public static bool CheckFilePath(string filePath) {
            if( System.IO.File.Exists(filePath) ) {
                return true;
            }
            return false;
        }

        public static bool CheckFolderPath(string folderPath) {
            if( System.IO.Directory.Exists(folderPath) ) {
                return true;
            }
            return false;
        }
            
        public static string GetTargetPath(string shortcutPath) { // unused?
            string targetPath = string.Empty;
            if( CheckFilePath(shortcutPath) ) {
                
            }
            return targetPath;
        }
        public static AppInfo GetAppInfo(string path) {
            if( !CheckFilePath(path) && !CheckFolderPath(path)) {
                throw new AppDoesNotExistException("The requested app does not exist or could not be found.");
            }

            string filename;
            Icon icon;
            string iconPath;
            SubAppType type = SubAppType.None;


            if( CheckFilePath(path) ) {
                filename = Path.GetFileNameWithoutExtension(path);
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
            } else {
                filename = path.Substring(path.LastIndexOf('\\') + 1);
                path = $"\"{path}\"";
                iconPath = null;
                icon = Properties.Resources.folder;
                type = SubAppType.Folder;
            }

            return new AppInfo(filename, path, iconPath, icon, type);
        }

        public static App GetMainApp(AppInfo info) {
            return mainAppFactory.CreateApp(info.Name, info.FilePath, info.IconPath, info.Icon, SubAppType.None);
        }

        public static App GetSubApp(AppInfo info) {
            return subAppFactory.CreateApp(info.Name, info.FilePath, info.IconPath, info.Icon, info.Type);
        }
    }
    [Serializable]
    public class AppInfo{
        public string Name { get; }
        public string FilePath { get; }
        public string IconPath { get; }
        public Icon Icon { get; set;  }
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
