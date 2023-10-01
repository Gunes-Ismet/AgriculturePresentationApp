using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class AboutSeedData : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasData(
                 new About { Id = 1, AboutHistory = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Totam atque cum alias iure in nulla ex, repellendus corrupti tempora voluptatem!", AboutUs = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." });
        }
    }
}
