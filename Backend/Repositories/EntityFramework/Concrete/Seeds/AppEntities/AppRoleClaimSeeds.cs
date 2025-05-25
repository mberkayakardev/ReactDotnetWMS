using Core.Entities.Abstract;
using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppRoleClaimSeeds : IEntityTypeConfiguration<AppRoleClaim>
    {
        public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
        {
            List<AppRoleClaim> AppRoleClaimList = new()
            {
                new AppRoleClaim
                {
                     Id = 1,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     ClaimId = 1,
                     RoleId = 1,
                },
                new AppRoleClaim
                {
                     Id = 2,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     ClaimId = 2,
                     RoleId = 1,
                },
                new AppRoleClaim
                {
                     Id = 3,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     ClaimId = 3,
                     RoleId = 1,
                },
                new AppRoleClaim
                {
                     Id = 4,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     ClaimId = 4,
                     RoleId = 1,
                }
            };


            builder.HasData(AppRoleClaimList);
        }
    }
}
