using Microsoft.EntityFrameworkCore;
using TrackerApi.Models;

namespace TrackerApi.Models;
public class TrackerApiContext : DbContext
{
  public DbSet<Student> Students { get; set; }
  public DbSet<Coach> Coaches { get; set; }
  public DbSet<Promotion> Promotions { get; set; }

  public TrackerApiContext(DbContextOptions<TrackerApiContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
     builder.Entity<Student>()
     .HasData(
        new Student { StudentId = 1, FirstN = "John", LastN = "Doe", Adult = false, Email = "JohnDoe@email.com", BeltId = 1, DateEnrolled = DateOnly.FromDateTime(DateTime.Now) },
        new Student { StudentId = 2, FirstN = "Jane", LastN = "Doe", Adult = false, Email = "JaneDoe@email.com", BeltId = 2, DateEnrolled = DateOnly.FromDateTime(DateTime.Now) },
        new Student { StudentId = 3, FirstN = "Johnny", LastN = "Bravo", Adult = false, Email = "JohnnyBravo@email.com", BeltId = 13, DateEnrolled = new DateOnly(2021,10,20) },
        new Student { StudentId = 4, FirstN = "Samurai", LastN = "Jack", Adult = false, Email = "SamuraiJack@email.com", BeltId = 20, DateEnrolled = new DateOnly(2019,5,10) }
     );
  }

  public DbSet<TrackerApi.Models.Coach> Coach { get; set; }
}
  

