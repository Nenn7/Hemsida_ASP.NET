using Microsoft.AspNetCore.Mvc;

namespace Hemsida_ASP.NET.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
