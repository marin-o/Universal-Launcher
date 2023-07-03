﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Launcher.AppClasses {
    public abstract class App {
        public Icon Icon { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Path { get; set; }


        public App(string name, string path, string iconPath, Icon icon) {
            Name = name;
            Path = path;
            IconPath = iconPath;
            Icon = icon;
        }
        public abstract void Launch();

    }
}