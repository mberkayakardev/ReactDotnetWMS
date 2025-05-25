using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dtos.Abstract;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Dtos.Concrete.AppDtos.AppReactMenus
{
    public class ListAppReactMenusDtos: BaseDtos
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public string? CreatedUserName { get; set; }
        public int? ModifiedUserId { get; set; }
        public string? ModifiedUserName { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public int AppClaimId { get; set; }
        public int AppApplicationTypeId { get; set; }
        public int? RootId { get; set; }
        public int MenuOrderNumber { get; set; }
        public string MenuTextName { get; set; }
        public string MenuTo { get; set; }
        public ListAppReactMenusDtos ParentMenu { get; set; }
        public List<ListAppReactMenusDtos> ChildMenus { get; set; }

    }
}
