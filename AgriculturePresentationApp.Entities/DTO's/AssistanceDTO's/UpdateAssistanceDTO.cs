using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s
{
    public class UpdateAssistanceDTO
    {
        public int Id { get; set; }
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
