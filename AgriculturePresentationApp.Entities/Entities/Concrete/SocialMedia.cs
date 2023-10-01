using AgriculturePresentationApp.Entities.Entities.Abstract;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
	public class SocialMedia : BaseEntity
	{
        public string Title { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }
    }
}
