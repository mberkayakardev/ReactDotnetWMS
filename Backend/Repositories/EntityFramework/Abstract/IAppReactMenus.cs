using Core.Entities.Concrete.AppEntities;
using Core.Repositories.EntityFramework.Abstract;

namespace Repositories.EntityFramework.Abstract
{
    public interface IAppReactMenus : IEfGenericRepositories<AppReactMenus>
    {
        Task<List<AppReactMenus>> GetReactMenusForUser(int Id);
    }
}
