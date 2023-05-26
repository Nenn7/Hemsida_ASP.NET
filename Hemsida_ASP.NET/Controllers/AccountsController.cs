using Hemsida_ASP.NET.Helpers.Services;
using Hemsida_ASP.NET.Models.Identities;
using Hemsida_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hemsida_ASP.NET.Controllers
{
	public class AccountsController : Controller
	{

		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserService _userService;

		public AccountsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, UserService userService)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_userService = userService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterUserViewModel model)
		{

			if (ModelState.IsValid)
			{
				AppUser user = model;

				if (await _userManager.FindByEmailAsync(model.Email) == null)
				{
					var result = await _userManager.CreateAsync(user, model.Password);

					if (result.Succeeded)
					{
						await _userService.AssignRoleAsync(user);
						if(model.ProfileImage != null)
						{
                            await _userService.UploadProfileImageAsync(user, model.ProfileImage);
                        }
						
						return RedirectToAction("Login", "Accounts");
					}
					else
						foreach (var error in result.Errors)
						{
							ModelState.AddModelError("", error.Description);
						}
				}
				else
				ModelState.AddModelError("", "A user with the same e-mail address already exists");
			}

			return View(model);
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
					ModelState.AddModelError("", "Incorrect email or password");
			}

			return View(model);
		}

        public async Task<IActionResult> Logout()
        {
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
        }


    }
}
