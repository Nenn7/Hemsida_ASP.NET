using Hemsida_ASP.NET.Models.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Hemsida_ASP.NET.Models.Entities;

public class ProductEntity
{
	[Key]
	public string ArticleId { get; set; } = null!;
	public string? ProductName { get; set; }
	public string? ProductImage { get; set; }

	[Column(TypeName = "money")]
	public decimal? Price { get; set; }
	public string? Ingress { get; set; }
	public string? Description { get; set; }

	public string? VendorName { get; set; }

	public ICollection<ProductTagEntity> Tags { get; set; } = new HashSet<ProductTagEntity>();

	public static implicit operator Product(ProductEntity entity)
	{
		List<string> TagList = new List<string>();

		foreach (var tag in entity.Tags)
		{
			TagList.Add(tag.Tag.TagName);
		}

		var product = new Product
		{
			ArticleId = entity.ArticleId,
			ProductName = entity.ProductName,
			ProductImage = entity.ProductImage,
			Price = entity.Price,
			Ingress = entity.Ingress,
			Description = entity.Description,
			VendorName = entity.VendorName,
			Tags = TagList
		};

		return product;
	}
}
