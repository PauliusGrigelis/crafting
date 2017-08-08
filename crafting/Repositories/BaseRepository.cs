using System;
using crafting.DataAccess;

namespace crafting.Repositories
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly DataContext Context;

        protected BaseRepository()
        {
            Context = DataContext.GetContext();
        }

        public void Dispose()
        {
            Context.SaveChanges();
            Context?.Dispose();
        }
    }
}
