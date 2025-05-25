using Core.Entities.Concrete.AppEntities;
using Core.Repositories.EntityFramework.Concrete;
using Microsoft.EntityFrameworkCore;
using QuizApp.Repositories.EntityFramework.Concrete.Contexts;
using Repositories.EntityFramework.Abstract;

namespace Repositories.EntityFramework.Concrete.Repositories
{
    public class EfAppReactMenus : EfGenericRepositories<AppReactMenus>, IAppReactMenus
    {
        public EfAppReactMenus(DbContext context) : base(context)
        {
        }

        public async Task<List<AppReactMenus>> GetReactMenusForUser(int Id)
        {
            var _dbcontext = _Context as AppDbContext;
            var UserMenus = await _dbcontext.AppReactMenus.ToListAsync();
            return UserMenus;
        }
    }
}
