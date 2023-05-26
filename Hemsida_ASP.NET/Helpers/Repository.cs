using Hemsida_ASP.NET.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hemsida_ASP.NET.Helpers;

public abstract class Repository<TEntity> where TEntity : class
{
	private readonly DataContext _dataContext;

	protected Repository(DataContext dataContext)
	{
		_dataContext = dataContext;
	}

	public virtual async Task<TEntity> AddAsync(TEntity entity)
	{
		_dataContext.Set<TEntity>().Add(entity);
		await _dataContext.SaveChangesAsync();
		return entity;
	}

	public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
	{
		var entity = await _dataContext.Set<TEntity>().FirstOrDefaultAsync(predicate);

		if (entity == null)
		{
			return null;
		}

		return entity;
	}

	public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
	{
		return await _dataContext.Set<TEntity>().ToListAsync();
	}

	public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
	{
		return await _dataContext.Set<TEntity>().Where(predicate).ToListAsync();
	}

	public virtual async Task<TEntity> UpdateAsync(TEntity entity)
	{
		_dataContext.Set<TEntity>().Update(entity);
		await _dataContext.SaveChangesAsync();
		return entity;
	}

	public virtual async Task RemoveAsync(TEntity entity)
	{
		_dataContext.Set<TEntity>().Remove(entity);
		await _dataContext.SaveChangesAsync();
	}
}
