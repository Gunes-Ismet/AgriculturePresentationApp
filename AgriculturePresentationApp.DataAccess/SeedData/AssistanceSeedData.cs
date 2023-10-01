using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class AssistanceSeedData : IEntityTypeConfiguration<Assistance>
    {
        public void Configure(EntityTypeBuilder<Assistance> builder)
        {
            builder.HasData(
                new Assistance { Id = 1, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Image = "61e99665-5c2c-4178-b9ab-d8aefe5bd16f_g6.jpg" },
                new Assistance { Id = 2, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Image = "66205b35-f8e9-4ed9-a134-71536c61eada_g7.jpg" },
                new Assistance { Id = 3, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Image = "a6185f8f-47fc-429f-8efb-9cb2a3137b5b_b3.jpg" },
                new Assistance { Id = 4, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Image = "fa5e16f2-4a50-4bd0-ae7e-c8060ad4dedf_g5.jpg" });
        }
    }
}
