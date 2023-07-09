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
        public App[] RecentlyUsed { get; set; } = null;
        public List<string> Categories { get; set; } = new List<string>();
        private int recentlyUsedIndex = 0;
        public int RecentlyUsedIndex { get { return recentlyUsedIndex; } }
            public void AddApp(App app) {
            Apps.Add(app);
        }
        public void RemoveApp(App app) {
            Apps.Remove(app);
            if( Favorites.Contains(app) ) 
                Favorites.Remove(app);
        }
        public void AddFavorite(App app) {
            Favorites.Add(app);
        }
        public void RemoveFavorite(App app) {
            Favorites.Remove(app);
        }

        public void AddRecentlyUsed(App app) {
            if( RecentlyUsed == null ) {
                RecentlyUsed = new App[5];
            }
            RecentlyUsed[recentlyUsedIndex] = app;
            recentlyUsedIndex++;
            if(recentlyUsedIndex >= 5) {
                recentlyUsedIndex = 0;
            }
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
