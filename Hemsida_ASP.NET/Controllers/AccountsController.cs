using Microsoft.AspNetCore.Mvc;

namespace Hemsida_ASP.NET.Controllers
{
	public class AccountsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}
	}
}
