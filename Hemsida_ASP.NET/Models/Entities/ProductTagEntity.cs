using Microsoft.EntityFrameworkCore;

namespace Hemsida_ASP.NET.Models.Entities;

[PrimaryKey("ArticleId", "TagId")]
public class ProductTagEntity
{
	public string ArticleId { get; set; } = null!;
	public ProductEntity Product { get; set; } = null!;
	public int TagId { get; set; }
	public TagEntity Tag { get; set; } = null!;
}
