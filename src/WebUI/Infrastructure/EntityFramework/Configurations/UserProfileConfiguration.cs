using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BuildHealth2013.WebUI.Models;

namespace BuildHealth2013.WebUI.Infrastructure.EntityFramework.Configurations
{
    public class UserProfileConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration()
        {
            ToTable("UserProfile");
            HasKey(e => e.UserId);
            Property(e => e.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}