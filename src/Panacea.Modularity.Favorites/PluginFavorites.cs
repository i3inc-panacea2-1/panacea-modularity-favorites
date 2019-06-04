using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Favorites
{
    [DataContract]
    public class PluginFavorites<T>
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "items")]
        public List<T> Items { get; set; }
    }
}
