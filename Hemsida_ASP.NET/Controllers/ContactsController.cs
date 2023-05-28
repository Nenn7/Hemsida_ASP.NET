using Hemsida_ASP.NET.Helpers.Services;
using Hemsida_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kurshemsida.Controllers
{
	public class ContactsController : Controller
	{
		private readonly ContactsService _contactsService;

		public ContactsController(ContactsService contactsService)
		{
			_contactsService = contactsService;
		}

		public IActionResult Index()
		{
			return View();
		}

		//Depending if the user email has sent a message via the form previously, adds a new user + message or adds a new message to existing user
		[HttpPost]
		public async Task<IActionResult> Index(ContactViewModel model)
		{
			if(ModelState.IsValid)
			{
				await _contactsService.AddOrUpdateContactAsync(model);
				return RedirectToAction("Index", "Home");
			}
			else 
			return View(model);
		}
	}
}
