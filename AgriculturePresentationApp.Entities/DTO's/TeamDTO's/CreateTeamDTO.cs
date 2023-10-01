using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s
{
    public class CreateTeamDTO
    {
        [DisplayName("Ad Soyad")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string FullName { get; set; }
        [DisplayName("Görevi")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string Title { get; set; }
        [DisplayName("Facebook Adresi")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string FacebookUrl { get; set; }
        [DisplayName("Twitter Adresi")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string TwitterUrl { get; set; }
        [DisplayName("Instagram Adresi")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string InstagramUrl { get; set; }
        [DisplayName("Web Adresi")]
        [Required(ErrorMessage = "Bu alan boş geçilemez!!")]
        public string WebSiteUrl { get; set; }
        [DisplayName("Görsel")]
        public IFormFile? UploadImage { get; set; }
        public string? ImageUrl { get; set; }
    }
}
