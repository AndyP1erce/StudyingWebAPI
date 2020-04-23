using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;

namespace WebApplication.DAL.Models

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) { }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Author> Authors { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => new { b.AgencyId, b.AuthorId});

            modelBuilder.Entity<Book>()
                .HasOne<Agency>(b => b.Agency)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AgencyId);

            modelBuilder.Entity<Book>()
                .HasOne<Author>(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}