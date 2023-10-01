using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class ContactSeedData : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                new Contact { Id = 1, Date = DateTime.Now, Mail = "lorem@lorem.com", Name = "Lorem Ipsum1", Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Contact { Id = 2, Date = DateTime.Now, Mail = "lorem@lorem.com", Name = "Lorem Ipsum2", Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Contact { Id = 3, Date = DateTime.Now, Mail = "lorem@lorem.com", Name = "Lorem Ipsum3", Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Contact { Id = 4, Date = DateTime.Now, Mail = "lorem@lorem.com", Name = "Lorem Ipsum4", Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit." },
                new Contact { Id = 5, Date = DateTime.Now, Mail = "lorem@lorem.com", Name = "Lorem Ipsum5", Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit." });
        }
    }
}
