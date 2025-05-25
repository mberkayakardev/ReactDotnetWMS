using Core.Entities.Concrete.AppEntities;
using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.AppDtos.AppMVCMenusDto;
using Dtos.Concrete.AppDtos.AppReactMenus;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract.AppService
{
    public interface IMenuService : IBaseServices
    {
        Task<IApiDataResult<List<ListAppMVCMenusDto>>> GetAppMVCMenusForUser(int UserId);

        Task<IApiDataResult<List<ListAppReactMenusDtos>>> GetAppReactMenusForUser(int Userid);
    }
}
