using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.Favorites
{
    public static class PanaceaServicesExtensions
    {
        public static IFavoritesPlugin GetFavoritesPlugin(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IFavoritesPlugin>();
        }

        public static bool TryGetFavoritesPlugin(this PanaceaServices core, out IFavoritesPlugin plugin)
        {
            plugin = null;
            var favorites = core.PluginLoader.GetPlugins<IFavoritesPlugin>().FirstOrDefault();
            if (favorites == null)
            {
                return false;
            }
            plugin = favorites;
            return true;
        }
    }
}
