using Hemsida_ASP.NET.Models.Identities;
using Hemsida_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hemsida_ASP.NET.Controllers
{
	[Authorize(Roles ="Administrator")]
	public class AdminController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public AdminController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			var viewModel = new UserListViewModel
			{
				Users = await _userManager.GetUsersInRoleAsync("StandardUser"),
			};

			return View(viewModel);
		}
	}
}
