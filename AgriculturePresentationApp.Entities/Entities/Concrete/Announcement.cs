using AgriculturePresentationApp.Entities.Entities.Abstract;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
    public class Announcement : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        private bool _status = false;
        public bool Status { get => _status; set => _status =value; }
    }
}
