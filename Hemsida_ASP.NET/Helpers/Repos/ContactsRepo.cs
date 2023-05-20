using Hemsida_ASP.NET.Contexts;
using Hemsida_ASP.NET.Models.Entities;

namespace Hemsida_ASP.NET.Helpers.Repos
{
	public class ContactsRepo : Repository<ContactEntity>
	{
		public ContactsRepo(DataContext dataContext) : base(dataContext)
		{
		}

	}
}
