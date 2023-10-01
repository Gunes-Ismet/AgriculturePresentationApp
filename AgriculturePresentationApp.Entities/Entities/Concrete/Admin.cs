using AgriculturePresentationApp.Entities.Entities.Abstract;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
	public class Admin : BaseEntity
	{
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
