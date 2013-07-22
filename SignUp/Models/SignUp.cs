using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignUp.Models
{
  public class SignUp
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "User Name required")]
    [Display(Name = "User Name")]
    public String UserName { get; set; }

    [Required(ErrorMessage = "First Name required")]
    [StringLength(100, MinimumLength = 3)]
    [Display(Name = "First Name")]
    public String FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(100,MinimumLength = 3)]
    [Display(Name = "Last Name")]
    public String LastName { get; set; }

    [Required(ErrorMessage = "Email Address is required")]
    [DataType(DataType.EmailAddress)]
    [MaxLength(50)]
    [Display(Name = "Email Address")]
    public String EmailAdress { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(3)]
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public String Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is required")]
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [MinLength(3)]
    [Compare("Password")]
    [NotMapped]
    public String ConfirmPassword { get; set; }

  }
}