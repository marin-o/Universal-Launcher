using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    public class AppDoesNotExistException : Exception {
        public AppDoesNotExistException(string message) : base(message) { }
        public override string ToString() {
            return Message;
        }
    }
}
