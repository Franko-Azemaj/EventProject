// #pragma warning disable CS8618
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace EventProject.Models;
// public class EventCreator
// {
//     [Key]
//     public int EventCreatorId { get; set; } 
//     [Required]
//     [MinLength(2)]
//     [MaxLength(50)]

//     [Display(Name = "First Name")]
//     public string FirstName { get; set; }
//     [Required]
//     [MinLength(2)]
//     [MaxLength(50)]

//     [Display(Name = "Last Name")]
//     public string LastName { get; set; } 

//     [Required]
//     [DataType(DataType.EmailAddress)]
//     public string Email { get; set; }

//     [DataType(DataType.Password)]
//     [Required]
//     [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
//     public string Password { get; set; } 
  
//     public DateTime CreatedAt { get; set; } = DateTime.Now;
//     public DateTime UpdatedAt { get; set; } = DateTime.Now;

//     public List<Event> CreatedEvents { get; set; } = new List<Event>(); 

//     [NotMapped]
//     [Compare("Password")]
//     [DataType(DataType.Password)]
//     [Display(Name = "Confirm PW")]
//     public string Confirm { get; set; } 
// }