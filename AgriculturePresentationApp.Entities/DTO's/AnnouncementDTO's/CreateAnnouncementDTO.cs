using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgriculturePresentationApp.Entities.DTO_s.AnnouncementDTO_s
{
    public class CreateAnnouncementDTO
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilemez!!")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez!!")]
        public string Description { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "Tarih boş geçilemez!!")]
        public DateTime Date { get; set; }

    }
}
