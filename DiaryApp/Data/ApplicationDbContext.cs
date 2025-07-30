using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var d1 = new DateTime(2024, 01, 10, 12, 00, 00, DateTimeKind.Utc);
            var d2 = new DateTime(2024, 02, 05, 15, 30, 00, DateTimeKind.Utc);
            var d3 = new DateTime(2024, 03, 12, 09, 45, 00, DateTimeKind.Utc);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Joe!",
                    CreationDate = d1
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Shoping",
                    Content = "Went shoping with Joe!",
                    CreationDate = d2
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "Went diving with Joe!",
                    CreationDate = d3
                }
                );
        }
    }
}
