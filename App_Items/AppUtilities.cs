//using IWshRuntimeLibrary;
using MetroFramework;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Universal_Launcher.Resources;

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
            if( !CheckFilePath(path) && !CheckFolderPath(path) ) {
                throw new AppDoesNotExistException("The requested app does not exist or could not be found.");
            }

            string filename;
            Icon icon;
            string iconPath;
            SubAppType type = SubAppType.None;


            if( CheckFilePath(path) ) {
                filename = Path.GetFileNameWithoutExtension(path);
                //if( Path.GetExtension(path).Equals(".lnk", StringComparison.OrdinalIgnoreCase) ) {
                //    IWshShell shell = new WshShell();
                //    IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path);
                //    iconPath = link.IconLocation;

                //    Icon extractedIcon = Icon.ExtractAssociatedIcon(iconPath);
                //    icon = new Icon(extractedIcon, SystemInformation.SmallIconSize);      //uncomment these lines and the using directive if someting breaks, but we should be fine, apparently
                //    type = SubAppType.Web;
                //}
                //else {
                    iconPath = path;
                    icon = Icon.ExtractAssociatedIcon(path);
                    type = SubAppType.Executable;
                //}
            }
            else {
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

        public static SubAppsUserControl GenerateExeSubApp(AppUserControl parent) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
            ofd.Title = "Select an Executable File, Shortcut, or Link File";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                SubAppsUserControl uc = new SubAppsUserControl();
                try {
                    AppInfo info = GetAppInfo(ofd.FileName);
                    App app = GetSubApp(info);
                    uc.SetApp(app);
                }
                catch( AppDoesNotExistException ex ) {
                    MetroMessageBox.Show(parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return uc;
            }
            return null;
        }

        public static SubAppsUserControl GenerateFolderSubApp(AppUserControl appUserControl, App parent) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a Folder";
            if( fbd.ShowDialog() == DialogResult.OK ) {
                string path = fbd.SelectedPath;
                SubAppsUserControl uc = new SubAppsUserControl();
                AppInfo info = GetAppInfo(path);
                SubApp app = GetSubApp(info) as SubApp;
                app.Parent = parent;
                uc.SetApp(app);
                return uc;
            }
            return null;
        }

        public static AppUserControl GenerateMainAppCard(Form1 parent) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files|*.exe|Shortcut Files|*.lnk|Internet Shortcuts|*.url";
            ofd.Title = "Select an Executable File, Shortcut, or Link File";
            if( ofd.ShowDialog() == DialogResult.OK ) {
                AppUserControl uc = new AppUserControl(Guid.NewGuid().ToString());
                try {
                    AppInfo info = GetAppInfo(ofd.FileName);
                    App app = GetMainApp(info);
                    uc.SetMainApp(app as MainApp);
                    return uc;
                }
                catch( AppDoesNotExistException ex ) {
                    MetroMessageBox.Show(parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        public static AppUserControl RegenrateAUC(App app) {
            AppUserControl uc = new AppUserControl(app as MainApp);
            //RedrawIcons(uc);
            //uc.SetMainApp(app as MainApp);
            return uc;
        }

        public static void RedrawIcons(AppUserControl uc) {
            App app = uc.MainApp;
            app.Icon = Icon.ExtractAssociatedIcon(app.Path);
            foreach( SubApp subApp in app.SubApps ) {
                try {
                    subApp.Icon = Icon.ExtractAssociatedIcon(subApp.IconPath);
                }
                catch (ArgumentException ex){
                    subApp.Icon = Properties.Resources.folder;
                }
            }
        }

        [Serializable]
        public class AppInfo {
            public string Name { get; }
            public string FilePath { get; }
            public string IconPath { get; }
            public Icon Icon { get; set; }
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
}
