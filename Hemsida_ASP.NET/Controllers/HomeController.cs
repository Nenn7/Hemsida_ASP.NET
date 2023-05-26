using Hemsida_ASP.NET.Helpers.Services;
using Hemsida_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers;

public class HomeController : Controller
{
	private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new ProductListViewModel
        {
            Featured = await _productService.GetProductsByTagNameAsync("Featured"),
            New = await _productService.GetProductsByTagNameAsync("New"),
            Popular = await _productService.GetProductsByTagNameAsync("Popular"),
        };

		return View(viewModel);
	}
}
