using System.Data.Entity;
using BuildHealth2013.WebUI.Infrastructure.EntityFramework.Configurations;
using BuildHealth2013.WebUI.Models;

namespace BuildHealth2013.WebUI.Infrastructure.EntityFramework
{
    public class BuildHealthContext : DbContext, IDbContext
    {
        public BuildHealthContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserProfileConfiguration());
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}