using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class ImageSeedData : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image { Id = 1, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "68deb826-4868-458f-977f-dfaec3238a3d_cay.jpg" },
                new Image { Id = 2, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "5fbf8f44-3739-46fc-9aa7-54cf1f7f5acd_bugday.jpg" },
                new Image { Id = 3, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "7f388cd2-20f0-4b32-aebb-f39934edea09_b3.jpg" },
                new Image { Id = 4, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "758ae01c-eb97-4396-8cf2-01da83533f42_g7.jpg" },
                new Image { Id = 5, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "260b6184-3906-4712-8027-57a35540e64b_g9.jpg" },
                new Image { Id = 6, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet.", ImageUrl = "1194798b-c2a3-4990-a489-87ca02088485_g1.jpg" });
        }
    }
}
