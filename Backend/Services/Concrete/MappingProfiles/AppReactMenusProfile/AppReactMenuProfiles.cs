using AutoMapper;
using Core.Entities.Concrete.AppEntities;
using Dtos.Concrete.AppDtos.AppReactMenus;

namespace Services.Concrete.MappingProfiles.AppReactMenusProfile
{
    public class AppReactMenuProfiles: Profile
    {
        public AppReactMenuProfiles()
        {
            CreateMap<AppReactMenus, ListAppReactMenusDtos>().ReverseMap();
        }
    }
}
