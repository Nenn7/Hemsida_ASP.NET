using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
