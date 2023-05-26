using Hemsida_ASP.NET.Models.Identities;

namespace Hemsida_ASP.NET.Models.ViewModels
{
    public class UserListViewModel
    {
        public IList<AppUser> Users { get; set; } = new List<AppUser>();
    }
}
