using System.ComponentModel.DataAnnotations;

namespace TrackerApi.Models
{
  public class Student
  {
    public int StudentId { get; set; }

    [Required]
    public string FirstN { get; set; }

    [Required]
    public string LastN { get; set; }

    [Required]
    public bool Adult { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public int BeltId { get; set; }

    [Required]
    public DateOnly DateEnrolled { get; set; }

    public List<Promotion> Promotions { get; set; }
  }
}