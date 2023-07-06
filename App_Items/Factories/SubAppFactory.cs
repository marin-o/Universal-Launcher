using System.Drawing;

namespace Universal_Launcher.App_Items {
    public class SubAppFactory : IAppFactory {
        public App CreateApp(string name, string path, string iconPath, Icon icon, SubAppType type) {
            return new SubApp(name, path, iconPath, icon, type);
        }
    }
}
