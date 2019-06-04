using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Favorites
{
    public class FriendlyNameAttribute : Attribute
    {
        public string Name { get; set; }
        public FriendlyNameAttribute(string name)
        {
            Name = name;
        }
    }
}
