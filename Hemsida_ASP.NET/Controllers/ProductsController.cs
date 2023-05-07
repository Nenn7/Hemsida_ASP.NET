using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Details()
		{
			return View();
		}

	}
}
