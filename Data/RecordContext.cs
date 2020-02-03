using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Record { get; set; }

        public RecordContext(
            DbContextOptions<RecordContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record>().ToTable("Record");
            modelBuilder.Entity<Record>()
                .Property(c => c.category)
                .HasConversion<string>();
            base.OnModelCreating(modelBuilder);
        }
    }
}