using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppReactMenuSeeds : IEntityTypeConfiguration<AppReactMenus>
    {
        public void Configure(EntityTypeBuilder<AppReactMenus> builder)
        {
            List<AppReactMenus> reactMenus = new List<AppReactMenus>
            {
                new AppReactMenus
                {
                    Id = 1,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     MenuName= "Dashboard",
                     MenuDescription = "React uygulaması giriş yapan kullanıcıyı karşılayan sayfa",
                     AppClaimId = 1,
                     AppApplicationTypeId = 2,
                     RootId = null,
                     MenuOrderNumber = 1,
                     MenuTextName = "DashBoard",
                     MenuTo = "/admin/dashboard"
                },
                               new AppReactMenus
                {
                    Id = 2,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     MenuName= "Admin Modül",
                     MenuDescription = "React uygulaması Admin Modül",
                     AppClaimId = 2,
                     AppApplicationTypeId = 2,
                     RootId = null,
                     MenuOrderNumber = 1,
                     MenuTextName = "DashBoard",
                     MenuTo = ""
                },

                         new AppReactMenus
                {
                    Id = 3,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     MenuName= "Kullanicilar",
                     MenuDescription = "React uygulaması Admin Modül Kullanicilar index sayfasi",
                     AppClaimId = 2,
                     AppApplicationTypeId = 2,
                     RootId = 2,
                     MenuOrderNumber = 1,
                     MenuTextName = "DashBoard",
                     MenuTo = "/admin/adminmodul/kullanicilar"
                },

                         new AppReactMenus
                {
                    Id = 4,
                     IsActive= true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     CreatedUserId = null,
                     CreatedUserName = "Sistem",
                     ModifiedUserId = null,
                     ModifiedUserName = "Sistem",
                     MenuName= "Roller",
                     MenuDescription = "React uygulaması Admin Modül Roller index sayfasi",
                     AppClaimId = 2,
                     AppApplicationTypeId = 2,
                     RootId = 2,
                     MenuOrderNumber = 2,
                     MenuTextName = "Roller",
                     MenuTo = "/admin/adminmodul/roller"
                },

            };

            builder.HasData(reactMenus);
        }
    }
}
