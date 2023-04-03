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
        new Student { StudentId = 1, FirstN = "John", LastN = "Doe", Adult = false, Email = "JohnDoe@email.com", BeltId = 1, DateEnrolled = DateTime.Now }, // "2023-04-03T00:00:00"
        new Student { StudentId = 2, FirstN = "Jane", LastN = "Doe", Adult = false, Email = "JaneDoe@email.com", BeltId = 2, DateEnrolled = DateTime.Now },
        new Student { StudentId = 3, FirstN = "Johnny", LastN = "Bravo", Adult = false, Email = "JohnnyBravo@email.com", BeltId = 13, DateEnrolled = DateTime.Now },
        new Student { StudentId = 4, FirstN = "Samurai", LastN = "Jack", Adult = false, Email = "SamuraiJack@email.com", BeltId = 20, DateEnrolled = DateTime.Now}
     );
    builder.Entity<Coach>()
    .HasData(
      new Coach { CoachId = 1, FirstN = "Jimmy", LastN = "Coacher", Email = "JimmyCoacher@email.com", Phone = "555-555-5555", BeltId = 15 },  
      new Coach { CoachId = 2, FirstN = "Sally", LastN = "Awesome", Email = "SallyAwesome@email.com", Phone = "555-555-5555", BeltId = 10 },
      new Coach { CoachId = 3, FirstN = "Sue", LastN = "Sensei", Email = "SueSensei@email.com", Phone = "555-555-5555", BeltId = 8 }
    );
  }
}
  

