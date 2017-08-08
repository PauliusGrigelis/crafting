using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crafting.Models;

namespace crafting.Repositories
{
    public class ItemRepository : BaseRepository
    {
        public List<Item> getItems()
        {
            return Context.Items.ToList();
        }
    }
}
