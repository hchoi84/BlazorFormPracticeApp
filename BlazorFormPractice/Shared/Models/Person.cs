using System.ComponentModel.DataAnnotations;

namespace BlazorFormPractice.Shared.Models;
public class Person
{
  [Required]
  [Display(Name = "First Name")]
  public string FirstName { get; set; } = string.Empty;

  [Required]
  [Display(Name = "Last Name")]
  public string LastName { get; set; } = string.Empty;

  [Required]
  [Display(Name = "Gender")]
  public string Gender { get; set; } = string.Empty;

  [Required]
  [Display(Name = "Age")]
  [Range(1, 100)]
  public int? Age { get; set; }

  [Display(Name = "Height Feet")]
  [Range(1, 10)]
  public int? HeightFeet { get; set; }

  [Display(Name = "Height Inch")]
  [Range(1, 11)]
  public int? HeightInch { get; set; }

  [Display(Name = "Eye Color")]
  public string EyeColor { get; set; } = string.Empty;
}
