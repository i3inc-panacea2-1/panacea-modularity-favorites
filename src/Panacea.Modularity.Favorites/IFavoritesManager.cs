using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Favorites
{
    public interface IFavoritesManager
    {
        event EventHandler FavoritesChanged;
        Task<bool> FavoriteAddAsync(string pluginName, string id);
        Task<bool> FavoriteRemoveAsync(string pluginName, string id);
        Task<List<T>> GetFavoritesAsync<T>(string pluginName);
    }
}
