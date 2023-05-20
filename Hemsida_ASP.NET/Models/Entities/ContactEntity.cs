namespace Hemsida_ASP.NET.Models.Entities;

public class ContactEntity
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string? PhoneNumber { get; set; }
	public string? Company { get; set; }
	public List<ContactMessageEntity> Messages { get; set; } = new List<ContactMessageEntity>(); 
}
