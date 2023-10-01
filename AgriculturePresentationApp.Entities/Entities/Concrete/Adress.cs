using AgriculturePresentationApp.Entities.Entities.Abstract;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
    public class Adress : BaseEntity
    {
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string MapInfo { get; set; }
    }
}
