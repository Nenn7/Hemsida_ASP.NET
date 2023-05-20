using Hemsida_ASP.NET.Contexts;
using Hemsida_ASP.NET.Models.Entities;

namespace Hemsida_ASP.NET.Helpers.Repos
{
	public class ProductsRepo : Repository<ProductEntity>
	{
		public ProductsRepo(DataContext dataContext) : base(dataContext)
		{
		}
	}
}
