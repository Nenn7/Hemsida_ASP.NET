using Hemsida_ASP.NET.Models.Entities;
using Hemsida_ASP.NET.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace Hemsida_ASP.NET.Models.ViewModels;

public class RegisterUserViewModel
{
	[Display(Name = "First Name")]
	[Required(ErrorMessage = "First Name is required")]
	public string FirstName { get; set; } = null!;

	[Display(Name = "Last Name")]
	[Required(ErrorMessage = "Last Name is required")]
	public string LastName { get; set; } = null!;

	[Display(Name = "Email Address")]
	[Required(ErrorMessage = "Email Address is required")]
	[DataType(DataType.EmailAddress)]
	[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email Address not valid")]
	public string Email { get; set; } = null!;

	[Display(Name = "Phone Number")]
	[DataType(DataType.PhoneNumber)]
	public string PhoneNumber { get; set; } = null!;

	[Display(Name = "Street Name")]
	[Required(ErrorMessage = "Street Name is required")]
	public string StreetName { get; set; } = null!;

	[Display(Name = "Postal Code")]
	[Required(ErrorMessage = "Postal Code is required")]
	public string PostalCode { get; set; } = null!;

	[Display(Name = "City")]
	[Required(ErrorMessage = "City is required")]
	public string City { get; set; } = null!;

	[Display(Name = "Company Name (optional)")]
	public string? Company { get; set; }

	[Display(Name = "Profile Image (optional)")]
	[DataType(DataType.Upload)]
	public IFormFile? ProfileImage { get; set; }

	[Display(Name = "Password")]
	[Required(ErrorMessage = "Password is required")]
	[DataType(DataType.Password)]
	[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s])[^\s]{8,}$", ErrorMessage = "Password must contain: 1 lowercase letter, 1 uppercase letter, atleast 1 digit, be atleast 8 characters long, and contain atleast one special character")]
	public string Password { get; set; } = null!;

	[Display(Name = "Confirm Password")]
	[Required(ErrorMessage = "Password does not match")]
	[DataType(DataType.Password)]
	[Compare(nameof(Password))]
	public string ConfirmPassword { get; set; } = null!;


	public static implicit operator AppUser(RegisterUserViewModel model)
	{
		var addressEntity = new AddressEntity
		{
			StreetName = model.StreetName,
			PostalCode = model.PostalCode,
			City = model.City,
		};

		var userEntity = new AppUser
		{
			FirstName = model.FirstName,
			LastName = model.LastName,
			Email = model.Email,
			PhoneNumber = model.PhoneNumber,
			Company = model.Company,
			ProfileImage = model.ProfileImage?.FileName,
			UserName = model.Email,
			Address = new List<AccountAddressEntity> 
        {
			new AccountAddressEntity
			{
				Address = addressEntity
			}
		}
		};

		return userEntity;
	}

}
