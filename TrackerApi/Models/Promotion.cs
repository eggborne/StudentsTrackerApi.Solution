using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackerApi.Models
{
  public class Promotion
  {
    public int PromotionId { get; set; }
    
    // [Required(ErrorMessage = "Please add a Student ID!")]
    public int StudentId { get; set; }
    
    // [Required(ErrorMessage = "Please add a Coach ID!")]
    public int CoachId { get; set; }

// 
    public DateTime PromotionDate { get; set; }

    // public List<Promotion> Promotions { get; }
  }
}