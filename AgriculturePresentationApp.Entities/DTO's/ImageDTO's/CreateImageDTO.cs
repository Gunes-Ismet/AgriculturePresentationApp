using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s
{
    public class CreateImageDTO
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilemez!!")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez!!")]
        public string Description { get; set; }

        [DisplayName("Görsel")]
        public IFormFile? UploadImage { get; set; }
        public string? ImageUrl { get; set; }
    }
}
