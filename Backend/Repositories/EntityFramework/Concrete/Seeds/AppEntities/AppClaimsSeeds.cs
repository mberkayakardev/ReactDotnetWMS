using Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppClaimsSeeds : IEntityTypeConfiguration<AppClaim>
    {
        public void Configure(EntityTypeBuilder<AppClaim> builder)
        {
            var AppClaimList = new List<AppClaim>
            {
                new AppClaim {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.Dashboard",
                    ClaimDescription = "Admin Layout içerisindeki Dashboard ın görülebilmesi için eklenmiş olan bir cliam dir."
                },

                new AppClaim {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "React.Admin.AdminModule",
                    ClaimDescription = "React uygulaması için yazılmış olan bir admin modül uygulamasıdır. "
                },


                new AppClaim {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "React.Admin.AdminModule.Kullanici.Index",
                    ClaimDescription = "React uygulaması Admin Modül için kullanıcıların Listelendiği ekran "
                },

                new AppClaim {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "React.Admin.AdminModule.Kullanici.Roller",
                    ClaimDescription = "React uygulaması Admin Modül için kullanıcıların Listelendiği ekran "
                },
            };



            builder.HasData(AppClaimList);
        }
    }
}
