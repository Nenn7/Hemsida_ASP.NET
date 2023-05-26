using Hemsida_ASP.NET.Helpers.Repos;
using Hemsida_ASP.NET.Helpers.Services;
using Hemsida_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers
{
	public class ProductsController : Controller
	{
		private readonly ProductsRepo _productsRepo;
		private readonly ProductService _productService;
        public ProductsController(ProductsRepo productsRepo, ProductService productService)
        {
            _productsRepo = productsRepo;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
		{
			var viewModel = new ProductListViewModel
			{
				AllProducts = await _productsRepo.GetAllAsync(),
			};

			return View(viewModel);
		}

		public async Task<IActionResult> Details(string articleId)
		{
			var product = await _productService.GetAsync(articleId);

			return View(product);
		}

	}
}
