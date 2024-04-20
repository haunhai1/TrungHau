using C1_3_webAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace C1_3_webAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(bc => new { bc.BookID, bc.AuthorID });

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(bc => bc.BookID);

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(bc => bc.AuthorID);
        }



        public DbSet<Book> books { get; set; }
        public DbSet<Authors> authors { get; set; }
        public DbSet<Book_Author> book_Authors { get; set; }
        public DbSet<Pulishers> pulishers { get; set; }
    }
}
