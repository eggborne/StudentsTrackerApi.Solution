using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackerApi.Models
{
  public class Promotion
  {
    public int PromotionId { get; set; }
    
    [Required(ErrorMessage = "Please add a Student ID!")]
    public string StudentId { get; set; }
    public Student Student { get; set; }
    
    [Required(ErrorMessage = "Please add a Coach ID!")]
    public string CoachId { get; set; }
    public Coach Coach { get; set; }

    public DateOnly PromotionDate { get; set; }

    public List<Promotion> Promotions { get; }
  }
}