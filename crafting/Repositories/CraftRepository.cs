using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crafting.Models;

namespace crafting.Repositories
{
    class CraftRepository : BaseRepository
    {
        public Item craftResult(List<string> components)
        {
            var crafts = Context.Crafts.ToList();
            foreach (var craft in crafts)
            {
                Context.Entry(craft).Collection(x => x.components).Load();
                Context.Entry(craft).Reference(x => x.item).Load();
                bool found = true;
                foreach(Item item in craft.components)
                {
                    if (!components.Contains(item.pic))
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return craft.item;
            }
            return null;
        }
    }
}
