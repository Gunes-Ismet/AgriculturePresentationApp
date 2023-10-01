using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class AnnouncementSeedData : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.HasData(
                new Announcement { Id = 1, Title = "Lorem ipsum", Date = DateTime.Now, Status = true, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." },
                new Announcement { Id = 2, Title = "Lorem ipsum", Date = DateTime.Now, Status = true, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." },
                new Announcement { Id = 3, Title = "Lorem ipsum", Date = DateTime.Now, Status = true, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." },
                new Announcement { Id = 4, Title = "Lorem ipsum", Date = DateTime.Now, Status = false, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." },
                new Announcement { Id = 5, Title = "Lorem ipsum", Date = DateTime.Now, Status = false, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." });
        }
    }
}
