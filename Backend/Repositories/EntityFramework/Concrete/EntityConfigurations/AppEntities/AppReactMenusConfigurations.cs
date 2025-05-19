using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Repositories.EntityFramework.Concrete.EntityConfigurations.AppEntities
{
    public class AppReactMenusConfiguration : IEntityTypeConfiguration<AppReactMenus>
    {
        public void Configure(EntityTypeBuilder<AppReactMenus> builder)
        {
            builder.ToTable("AppReactMenus");

            builder.HasOne(m => m.ParentMenu)
                   .WithMany(m => m.ChildMenus)
                   .HasForeignKey(m => m.RootId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
