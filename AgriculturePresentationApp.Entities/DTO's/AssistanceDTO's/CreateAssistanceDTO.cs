using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s
{
    public class CreateAssistanceDTO
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilemez!!")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez!!")]
        public string Description { get; set; }
        public string? Image { get; set; }
        [DisplayName("Görsel")]
        public IFormFile? UploadImage { get; set; }
    }
}
