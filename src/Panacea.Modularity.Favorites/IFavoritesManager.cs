using Panacea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Panacea.Modularity.Favorites
{
    public interface IFavoritesManager
    {
        Task<bool> AddOrRemoveFavoriteAsync(string pluginName, ServerItem item);
    }
}
