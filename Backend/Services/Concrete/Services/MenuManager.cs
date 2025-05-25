using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Core.Utilities.Results.MVC.ComplexTypes;
using Dtos.Concrete.AppDtos.AppMVCMenusDto;
using Dtos.Concrete.AppDtos.AppReactMenus;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract.AppService;
using static Services.Concrete.message.Messages;

namespace Services.Concrete.Services
{
    public class MenuManager : BaseServices, IMenuService
    {
        public MenuManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IApiDataResult<List<ListAppMVCMenusDto>>> GetAppMVCMenusForUser(int UserId)
        {
            var UserMenus = await _unitOfWork.AppUserRepositories.GetAppMVCMenusForUser(UserId);
            if (UserMenus.Count == 0 ) 
                return new ApiDataResult<List<ListAppMVCMenusDto>>(default, ApiResultStatus.NotFound, Menus.NotFound);

            var mappedData = _mapper.Map<List<ListAppMVCMenusDto>>(UserMenus);

            return new ApiDataResult<List<ListAppMVCMenusDto>>(mappedData, ApiResultStatus.Ok);
        }

        public async Task<IApiDataResult<List<ListAppReactMenusDtos>>> GetAppReactMenusForUser(int Userid)
        {
            var UserMenus = await _unitOfWork.AppReactMenus.GetReactMenusForUser(Userid);
            if (UserMenus.Count == 0)

                return new ApiDataResult<List<ListAppReactMenusDtos>>(default, ApiResultStatus.NotFound, Menus.NotFound);

            var mappedData = _mapper.Map<List<ListAppReactMenusDtos>>(UserMenus);

            var RecursiveResult = BuildMenuTreeRect(mappedData);

            return new ApiDataResult<List<ListAppReactMenusDtos>>(RecursiveResult, ApiResultStatus.Ok);
        }

        #region Build Menu Trees

        private List<ListAppReactMenusDtos> BuildMenuTreeRect(List<ListAppReactMenusDtos> allMenus, int? parentId = null)
        {
            return allMenus
                .Where(menu => menu.RootId == parentId)
                .Select(menu => new ListAppReactMenusDtos
                {
                    Id = menu.Id,
                    IsActive = menu.IsActive,
                    CreatedDate = menu.CreatedDate,
                    ModifiedDate = menu.ModifiedDate,
                    CreatedUserId = menu.CreatedUserId,
                    CreatedUserName = menu.CreatedUserName,
                    ModifiedUserId = menu.ModifiedUserId,
                    ModifiedUserName = menu.ModifiedUserName,
                    MenuName = menu.MenuName,
                    MenuDescription = menu.MenuDescription,
                    AppClaimId = menu.AppClaimId,
                    AppApplicationTypeId = menu.AppApplicationTypeId,
                    RootId = menu.RootId,
                    MenuOrderNumber = menu.MenuOrderNumber,
                    MenuTextName = menu.MenuTextName,
                    MenuTo = menu.MenuTo,
                    ParentMenu = allMenus.FirstOrDefault(x => x.Id == menu.RootId),
                    ChildMenus = BuildMenuTreeRect(allMenus, menu.Id)
                })
                .OrderBy(menu => menu.MenuOrderNumber)
                .ToList();
        }

        #endregion
    }
}
