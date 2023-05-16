using System.ComponentModel.DataAnnotations;

namespace Hemsida_ASP.NET.Models.Entities;

public class TagEntity
{
	[Key]
	public int TagId { get; set; }
	public string TagName { get; set; } = null!;

	public ICollection<ProductTagEntity> Products { get; set; } = new HashSet<ProductTagEntity>();
}
