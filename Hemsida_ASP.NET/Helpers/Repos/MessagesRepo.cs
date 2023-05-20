using Hemsida_ASP.NET.Contexts;
using Hemsida_ASP.NET.Models.Entities;

namespace Hemsida_ASP.NET.Helpers.Repos
{
	public class MessagesRepo : Repository<ContactMessageEntity>
	{
		public MessagesRepo(DataContext dataContext) : base(dataContext)
		{
		}
	}
}
