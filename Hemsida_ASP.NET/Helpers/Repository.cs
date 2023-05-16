using Hemsida_ASP.NET.Contexts;

namespace Hemsida_ASP.NET.Helpers
{
	public abstract class Repository
	{
		private readonly DataContext _dataContext;

		protected Repository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
	}
}
