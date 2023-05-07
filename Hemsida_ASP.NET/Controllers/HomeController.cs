using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
