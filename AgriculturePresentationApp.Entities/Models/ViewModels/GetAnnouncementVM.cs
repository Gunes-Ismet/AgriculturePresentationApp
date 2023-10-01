namespace AgriculturePresentationApp.Entities.Models.ViewModels
{
    public class GetAnnouncementVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
