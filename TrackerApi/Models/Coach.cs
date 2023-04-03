using System.ComponentModel.DataAnnotations;

namespace TrackerApi.Models
{
  public class Coach
  {
    public int CoachId { get; set; }

    [Required]
    public string FirstN { get; set; }

    [Required]
    public string LastN { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Phone { get; set; }

    [Required]
    public string BeltId { get; set;}

    public List<Promotion> Promotions { get; }
  }
}