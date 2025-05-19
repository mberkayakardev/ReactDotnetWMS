namespace Core.Entities.Concrete.AppEntities
{
    public class AppReactMenus : AppMenus
    {
        public int? RootId { get; set; }
        public int MenuOrderNumber { get; set; }
        public string MenuTextName { get; set; }
        public string MenuTo { get; set; }
        public AppReactMenus ParentMenu { get; set; }

        public List<AppReactMenus> ChildMenus { get; set; }
    }
}
