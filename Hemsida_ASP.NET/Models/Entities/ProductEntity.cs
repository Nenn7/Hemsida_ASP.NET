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
    [DisplayFormat(DataFormatString = "{0:C0}")]
    public decimal? Price { get; set; }
	public string? Ingress { get; set; }
	public string? Description { get; set; }

	public string? VendorName { get; set; }

	public ICollection<ProductTagEntity> Tags { get; set; } = new HashSet<ProductTagEntity>();

}
