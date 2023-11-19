using ClassMovie.Domain.DbModels;
using Microsoft.EntityFrameworkCore;
namespace CleanMovie.Infrastructure
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(pk => pk.MovieId);
            modelBuilder.Entity<Member>().HasKey(pk => pk.MemberId);
            modelBuilder.Entity<Rental>().HasKey(pk => pk.RentalId);
            modelBuilder.Entity<MovieRental>().HasKey(pk => pk.MovieRentalId);
            // Handle Decimals to avoid precision loss
            modelBuilder.Entity<Rental>()
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Movie>()
                .Property(p => p.RentalCost)
                .HasColumnType("decimal(18,2)");
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }

    }
}
