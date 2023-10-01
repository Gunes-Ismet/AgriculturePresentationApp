using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s
{
    public class UpdateImageDTO
    {
        public int Id { get; set; }
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
