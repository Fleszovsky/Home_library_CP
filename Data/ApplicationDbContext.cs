using Biblioteka.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configuring the ApplicationUser-Reviews relationship
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            // Configuring the ApplicationUser-Reservations relationship
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            // Configuring the Book-Author relationship
            builder.Entity<Book>()
                .HasOne(a => a.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring the Book-Borrowings relationship
            builder.Entity<Book>()
                .HasMany(a => a.Borrowings)
                .WithOne(b => b.Book)
                .HasForeignKey(c => c.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring the Borrowing-IdentityUser relationship
            builder.Entity<Borrowing>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(b => b.UserId)
                .IsRequired(true);

            // Configuring the Reservation-Book relationship
            builder.Entity<Reservation>()
                .HasOne(a => a.Book)
                .WithMany()
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring the Review-Book relationship
            builder.Entity<Review>()
                .HasOne(a => a.Book)
                .WithMany()
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}