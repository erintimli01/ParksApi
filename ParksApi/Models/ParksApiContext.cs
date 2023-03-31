using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksApiContext(DbContextOptions<ParksApiContext> options) : base (options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Zion National Park", State = "Utah", City = "Springdale" },
          new Park { ParkId = 2, Name = "Yosemite National Park", State = "California", City = "Sacramento" },
          new Park { ParkId = 3, Name = "Grand Canyon National Park", State = "Arizona", City = "Tusayan" },
          new Park { ParkId = 4, Name = "Big Bend National Park", State = "Texas", City = "Big Bend" },
          new Park { ParkId = 5, Name = "Yellowstone National Park", State = "Montana", City = "Gardiner"}
        );
    }
  }
}