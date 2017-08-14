using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crafting.Models;

namespace crafting.Repositories
{
    public class InventoryRepository : BaseRepository
    {
        public List<Item> getItems()
        {
            var inventory = Context.Inventories.FirstOrDefault(x => x.Id == 1);
            Context.Entry(inventory).Collection(x => x.items).Load();
            return inventory.items.ToList();
        }
    }
}
