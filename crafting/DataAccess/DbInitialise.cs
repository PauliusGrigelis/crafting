using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crafting.Models;

namespace crafting.DataAccess
{
    class DbInitialise : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Items.Add(new Item { Name = "boots", pic = @"./item_icons/boots.png" });
            context.Items.Add(new Item { Name = "crap", pic = @"./item_icons/crap.jpg" });
            context.Items.Add(new Item { Name = "log", pic = @"./item_icons/logo.png" });
            context.Items.Add(new Item { Name = "rock", pic = @"./item_icons/rock.png" });
            context.Items.Add(new Item { Name = "water", pic = @"./item_icons/water.png" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
