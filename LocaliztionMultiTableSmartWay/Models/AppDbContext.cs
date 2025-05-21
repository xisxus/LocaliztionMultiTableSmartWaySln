using Microsoft.EntityFrameworkCore;

namespace LocaliztionMultiTableSmartWay.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<LanguageMainTable> LanguageMainTables { get; set; }
        public DbSet<LanguageList> LanguageLists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageMainTable>()
                .HasKey(l => l.Id);
            modelBuilder.Entity<LanguageList>()
                .HasKey(l => l.Id);
        }
    }
    
}
