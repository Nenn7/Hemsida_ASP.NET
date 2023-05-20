using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hemsida_ASP.NET.Models.Dtos;

public class Product
{
	public string? ArticleId { get; set; } 
	public string? ProductName { get; set; }
	public string? ProductImage { get; set; }
	public decimal? Price { get; set; }
	public string? Ingress { get; set; }
	public string? Description { get; set; }
	public string? VendorName { get; set; }
	public List<string>? Tags { get; set; } = new List<string>();
}
