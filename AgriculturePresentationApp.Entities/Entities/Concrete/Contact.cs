using AgriculturePresentationApp.Entities.Entities.Abstract;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
