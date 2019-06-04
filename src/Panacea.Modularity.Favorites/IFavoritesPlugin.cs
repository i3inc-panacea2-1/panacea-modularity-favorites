using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Favorites
{
    public interface IFavoritesPlugin : IPlugin
    {
        event EventHandler FavoritesChanged;
        Task FavoriteNotify(string pluginName, string id);
        Task FavoriteRemove(string pluginName, string id);
        Task<List<T>> GetFavoritesAsync<T>(string pluginName);
    }
}
