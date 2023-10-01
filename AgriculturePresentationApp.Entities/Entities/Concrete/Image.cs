using AgriculturePresentationApp.Entities.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriculturePresentationApp.Entities.Entities.Concrete
{
    public class Image : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }
    }
}
