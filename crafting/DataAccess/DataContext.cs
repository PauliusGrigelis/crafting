using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crafting.Models;
using System.Data.Entity;

namespace crafting.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=alfaDb")
        {
            Database.SetInitializer(new DbInitialise());
            //Configuration.LazyLoadingEnabled = true;
            Database.Initialize(true);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Craft> Crafts { get; set; }
        public DbSet<Models.Inventory> Inventories { get; set; }


        public static DataContext GetContext()
        {            
            return new DataContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here

            modelBuilder.Entity<Item>();
            modelBuilder.Entity<Craft>();
            modelBuilder.Entity<Models.Inventory>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
