using Hemsida_ASP.NET.Models.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hemsida_ASP.NET.Helpers.Services
{
	public class UserService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IWebHostEnvironment _webHostEnvironment;

        public UserService(UserManager<AppUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task AssignRoleAsync(AppUser user)
		{
			var users = await _userManager.Users.CountAsync();

			if (users > 1)
			{
				await _userManager.AddToRoleAsync(user, "StandardUser");
			}
			else
				await _userManager.AddToRoleAsync(user, "Administrator");
		}

		public async Task<bool> UploadProfileImageAsync(AppUser user, IFormFile image)
		{
			try
			{
				string imagePath = $"{_webHostEnvironment.WebRootPath}/images/profileImages/{user.ProfileImage}";
				await image.CopyToAsync(new FileStream(imagePath, FileMode.Create));	
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
