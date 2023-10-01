using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriculturePresentationApp.DataAccess.SeedData
{
    public class TeamSeedData : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team { Id = 1, FullName = "Lorem Ipsum", Title = "Lorem", FacebookUrl = "#", InstagramUrl = "#", TwitterUrl = "#", WebSiteUrl = "#", ImageUrl = "af4ceaf0-1434-4a02-8f62-55f8d512b561_t3.jpg" },
                new Team { Id = 2, FullName = "Lorem Ipsum", Title = "Lorem", FacebookUrl = "#", InstagramUrl = "#", TwitterUrl = "#", WebSiteUrl = "#", ImageUrl = "32936630-f4fc-4972-91ea-d63dfa071104_t1.jpg" },
                new Team { Id = 3, FullName = "Lorem Ipsum", Title = "Lorem", FacebookUrl = "#", InstagramUrl = "#", TwitterUrl = "#", WebSiteUrl = "#", ImageUrl = "ba08bcd5-193b-4e37-a943-a9db7905048c_t2.jpg" },
                new Team { Id = 4, FullName = "Lorem Ipsum", Title = "Lorem", FacebookUrl = "#", InstagramUrl = "#", TwitterUrl = "#", WebSiteUrl = "#", ImageUrl = "d5648bb7-12d8-4af5-a5cd-a5de8111f7ed_t4.jpg" });
        }
    }
}
