using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class SocialMediaSeedData : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasData(
                new SocialMedia { Id = 1, Title = "facebook", Icon = "fa fa-facebook", Url = "https://facebook.com" },
                new SocialMedia { Id = 2, Title = "twitter", Icon = "fa fa-twitter", Url = "https://facebook.com" },
                new SocialMedia { Id = 3, Title = "linkedin", Icon = "fa fa-linkedin", Url = "https://facebook.com" },
                new SocialMedia { Id = 4, Title = "youtube", Icon = "fa fa-youtube", Url = "https://facebook.com" });
        }
    }
}
