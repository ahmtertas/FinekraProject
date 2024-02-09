using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T>
	{
		IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);
		T GetValue(Expression<Func<T, bool>> filter = null);
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
