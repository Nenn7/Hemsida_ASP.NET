using Hemsida_ASP.NET.Models.Identities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hemsida_ASP.NET.Models.Entities;

[PrimaryKey(nameof(UserId), nameof(AddressId))]
public class AccountAddressEntity
{
	[ForeignKey(nameof(User))]
	public string UserId { get; set; } = null!;
	public AppUser User { get; set; } = null!;

	[ForeignKey(nameof(Address))]
	public int AddressId { get; set; }
	public AddressEntity Address { get; set; } = null!;
}