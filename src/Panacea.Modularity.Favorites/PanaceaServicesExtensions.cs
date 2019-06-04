using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.Favorites
{
    public static class PanaceaServicesExtensions
    {
        public static bool TryGetFavoritesPlugin(this PanaceaServices core, out IFavoritesManager plugin)
        {
            plugin = null;
            var favorites = core.PluginLoader.GetPlugins<IFavoritesPlugin>().FirstOrDefault();
            if (favorites == null)
            {
                return false;
            }
            plugin = favorites.GetManager();
            return true;
        }
    }
}
