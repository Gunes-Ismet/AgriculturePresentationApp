using AgriculturePresentationApp.Entities.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
    }
}
