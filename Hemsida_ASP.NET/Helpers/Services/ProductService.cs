using Hemsida_ASP.NET.Contexts;
using Hemsida_ASP.NET.Helpers.Repos;
using Hemsida_ASP.NET.Models.Dtos;
using Hemsida_ASP.NET.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hemsida_ASP.NET.Helpers.Services
{
	public class ProductService
	{
		private readonly ProductsRepo _productsRepo;
		private readonly DataContext _context;

		public ProductService(ProductsRepo productsRepo, DataContext context)
		{
			_productsRepo = productsRepo;
			_context = context;
		}

		public async Task<IEnumerable<Product>> GetProductsByTagNameAsync(string tagName)
		{
			var products = await _context.Products
				.Where(x => x.Tags.Any(x => x.Tag.TagName == tagName))
				.ToListAsync();

			var productsList = new List<Product>();

			foreach(var productEntity in products)
			{
				Product product = productEntity; 
				productsList.Add(product);
			}

			return productsList;

		}
	}
}
