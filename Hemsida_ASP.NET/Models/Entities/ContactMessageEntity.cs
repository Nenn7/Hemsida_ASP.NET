namespace Hemsida_ASP.NET.Models.Entities;

public class ContactMessageEntity
{
	public int Id { get; set; }
	public string Message { get; set; } = null!;
	public int ContactId { get; set; }
	public ContactEntity Contact { get; set; } = null!;
}