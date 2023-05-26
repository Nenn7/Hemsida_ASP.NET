using System.ComponentModel.DataAnnotations;

namespace Hemsida_ASP.NET.Models.ViewModels;

public class ContactViewModel
{
	[Display(Name = "Your Name")]
	[Required(ErrorMessage = "Name is required")]
	public string Name { get; set; } = null!;

	[Display(Name = "Email Address")]
	[Required(ErrorMessage = "Email Address is required")]
	[DataType(DataType.EmailAddress)]
	[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email Address not valid")]
	public string Email { get; set; } = null!;

	[Display(Name = "Phone Number (optional)")]
	[DataType(DataType.PhoneNumber)]
	public string? PhoneNumber { get; set; }


	[Display(Name = "Company Name (optional)")]
	public string? Company { get; set; }


	[Display(Name = "Your Message:")]
	[Required]
	public string Message { get; set; } = null!;
}
