using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s
{
    public class UpdateTeamDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string WebSiteUrl { get; set; }
        [DisplayName("Görsel")]
        public IFormFile? UploadImage { get; set; }
        public string? ImageUrl { get; set; }
    }
}
