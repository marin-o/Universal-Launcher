using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Launcher.App_Items {
    [Serializable]
    public class AppRepository { 
        public List<App> Apps { get; set; } = new List<App>();
        public List<App> Favorites { get; set; } = new List<App>();
        public List<App> RecentlyUsed { get; set; } = new List<App>();
        public List<string> Categories { get; set; } = new List<string>();
        public void AddApp(App app) {
            Apps.Add(app);
        }
        public void RemoveApp(App app) {
            Apps.Remove(app);
        }
        public void AddFavorite(App app) {
            Favorites.Add(app);
        }
        public void RemoveFavorite(App app) {
            Favorites.Remove(app);
        }

        public void AddRecentlyUsed(App app) {
            RecentlyUsed.Insert(0,app);
            if(RecentlyUsed.Count == 6 ) {
                RecentlyUsed.RemoveAt(5);
            }
        }
        public void RemoveRecentlyUsed(App app) {
            RecentlyUsed.Remove(app);
        }

        public void AddCategory(string category) {
            if( !Categories.Contains(category))
                Categories.Add(category);
        }

        public void RemoveCategory(string oldCategory) {
            Categories.Remove(oldCategory);
        }
    }
}
