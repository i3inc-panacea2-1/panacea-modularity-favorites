using Panacea.Models;
using System.Collections.Generic;

namespace Panacea.Modularity.Favorites
{
    public interface IHasFavoritesPlugin : IPlugin
    {
        List<ServerItem> Favorites { get; set; }
    }    
}
