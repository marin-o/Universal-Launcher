using System.Drawing;

namespace Universal_Launcher.App_Items {
    public interface IAppFactory {
        App CreateApp(string name, string path, string iconPath, Icon icon, SubAppType type = SubAppType.None);
    }
}
