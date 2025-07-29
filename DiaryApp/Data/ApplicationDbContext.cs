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

        // Four steps to add a table:
        // 1. Create a model class (DiaryEntry)
        // 2. Add a DbSet property in ApplicationDbContext
        // 3. Add a migration using the command: add-migration AddDiaryEntryTable
        // 4. Update the database using the command: update-database
    }
}
