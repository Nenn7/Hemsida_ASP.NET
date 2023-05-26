using Hemsida_ASP.NET.Models.Dtos;
using Hemsida_ASP.NET.Models.Entities;

namespace Hemsida_ASP.NET.Models.ViewModels;

public class ProductListViewModel
{
    public IEnumerable<Product> Featured { get; set; } = new List<Product>();
    public IEnumerable<Product> New { get; set; } = new List<Product>();
    public IEnumerable<Product> Popular { get; set; } = new List<Product>();
    public IEnumerable<ProductEntity> AllProducts { get; set; } = new List<ProductEntity>();
}
