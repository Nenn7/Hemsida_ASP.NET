using Hemsida_ASP.NET.Models.Entities;
using Microsoft.AspNetCore.Identity;
namespace Hemsida_ASP.NET.Models.Identities;

public class AppUser : IdentityUser
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string? Company { get; set; }
	public string? ProfileImage { get; set; }
	public ICollection<AccountAddressEntity> Address { get; set; } = null!;
}