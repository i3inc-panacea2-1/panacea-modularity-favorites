using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Favorites
{
    public interface IFavoritesPlugin : IPlugin
    {
        Task FavoriteNotify(string pluginName, string id);
        Task FavoriteRemove(string pluginName, string id);
        List<T> GetFavorites<T>(string pluginName);
    }
}
