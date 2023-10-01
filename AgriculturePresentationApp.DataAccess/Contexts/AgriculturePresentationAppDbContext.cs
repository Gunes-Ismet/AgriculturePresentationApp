using AgriculturePresentationApp.DataAccess.SeedData;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriculturePresentationApp.DataAccess.Contexts
{
    public class AgriculturePresentationAppDbContext : IdentityDbContext<ApplicationAdmin>
    {
        public AgriculturePresentationAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Announcement> Announcements  { get; set; }
        public DbSet<Assistance> Assistances { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Team> Teams { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<About> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AboutSeedData());
            builder.ApplyConfiguration(new AdressSeedData());
            builder.ApplyConfiguration(new AnnouncementSeedData());
            builder.ApplyConfiguration(new AssistanceSeedData());
            builder.ApplyConfiguration(new ContactSeedData());
            builder.ApplyConfiguration(new ImageSeedData());
            builder.ApplyConfiguration(new SocialMediaSeedData());
            builder.ApplyConfiguration(new TeamSeedData());

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "d575f12c-a0d3-4ead-b94c-c0ee62ef7652", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });

            var hasher = new PasswordHasher<ApplicationAdmin>();

            builder.Entity<ApplicationAdmin>().HasData
                (
                    new ApplicationAdmin
                    {
                        Id = "9588b738-b7c2-4dab-96f7-5ccedde5be23",
                        UserName = "admin",
                        NormalizedUserName = "ADMIN",
                        Email = "admin@admin.com",
                        PasswordHash = hasher.HashPassword(null, "1234")
                    }
                );

            builder.Entity<IdentityUserRole<string>>().HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "d575f12c-a0d3-4ead-b94c-c0ee62ef7652",
                        UserId = "9588b738-b7c2-4dab-96f7-5ccedde5be23"
                    }
                );
        }
    }
}
