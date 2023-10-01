using System.ComponentModel;

namespace AgriculturePresentationApp.Entities.DTO_s.ContactDTO_s
{
    public class CreateContactDTO
    {
		[DisplayName("Adı Soyad")]
		public string Name { get; set; }
		[DisplayName("Mail")]
		public string Mail { get; set; }
		[DisplayName("Mesaj")]
		public string Message { get; set; }

		private DateTime _date = DateTime.Now;
		public DateTime Date { get => _date; set => _date = value; }
	}
}
