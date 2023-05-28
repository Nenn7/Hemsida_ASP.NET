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

		//Makes sure that the first user registering becomes admin, and the following users standardusers
        public async Task AssignRoleAsync(AppUser user)
		{
			var users = await _userManager.Users.CountAsync();

			//>1 due to the user getting created before this method runs, therefore 1 user being present in the count
			if (users > 1)
			{
				await _userManager.AddToRoleAsync(user, "StandardUser");
			}
			else
				await _userManager.AddToRoleAsync(user, "Administrator");
		}

		//For enabling uploading of a profile image upon registration
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
