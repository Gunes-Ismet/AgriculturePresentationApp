using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class AdressSeedData : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasData(
                new Adress { Id = 1, Description1 = "Güneş Mh. Yıldız Cd. No:22", Description3 = "Kızılay Ankara", Description2 = "agriculture@gmail.com", Description4 = "0 530 000 00 00", MapInfo = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5296.639074635017!2d32.83117527991754!3d39.92476403024208!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d34f190a9cea8f%3A0xd3862ea8248d08a0!2sAn%C4%B1tkabir!5e0!3m2!1str!2str!4v1692655486283!5m2!1str!2str" });
        }
    }
}
