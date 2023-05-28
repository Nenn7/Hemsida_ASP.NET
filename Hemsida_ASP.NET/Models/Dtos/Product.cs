using Hemsida_ASP.NET.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hemsida_ASP.NET.Models.Dtos;

public class Product
{
	public string? ArticleId { get; set; } 
	public string? ProductName { get; set; }
	public string? ProductImage { get; set; }

    [DisplayFormat(DataFormatString = "{0:C0}")]
    public decimal? Price { get; set; }
	public string? Ingress { get; set; }
	public string? Description { get; set; }
	public string? VendorName { get; set; }
	public List<string>? Tags { get; set; } = new List<string>();

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
