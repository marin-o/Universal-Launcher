using System;


namespace Universal_Launcher.App_Items {
    [Serializable]
    public class SubApp : App {
        public SubAppType Type { get; set; }
        public App Parent { get; set; }
        public SubApp(string name, string path, string iconPath, System.Drawing.Icon icon, SubAppType type) : base(name, path, iconPath, icon) {
            Type = type;
        }

        public override void Launch() {
            switch (Type) {
                case SubAppType.Executable:
                case SubAppType.Web:
                    try {
                        System.Diagnostics.Process.Start(Path);
                    }
                    catch ( System.ComponentModel.Win32Exception ex ) {
                        //do nothing
                    }
                    break;
                case SubAppType.Folder:
                    System.Diagnostics.Process.Start(Parent.Path, Path);
                    break;
            }
        }
    }
}
