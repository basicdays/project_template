using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BuildHealth2013.WebUI.Infrastructure.DataAccess
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
        void Dispose();

        DbEntityEntry Entry(object toUpdate);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity toUpdate)
            where TEntity : class;
    }
}