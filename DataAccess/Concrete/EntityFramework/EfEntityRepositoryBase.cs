using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public abstract class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
		where TEntity : class, new()
	{
		protected readonly FinekraContext context;
		public EfEntityRepositoryBase(FinekraContext context)
		{
			this.context = context;
		}
		public void Insert(TEntity entity)
		{
			var addedEntity = context.Entry(entity);
			addedEntity.State = EntityState.Added;
			context.SaveChanges();
		}

		public void Delete(TEntity entity)
		{
			var deletedEntity = context.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			context.SaveChanges();
		}

		public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			return filter == null ?
				context.Set<TEntity>().AsQueryable() :
				context.Set<TEntity>().Where(filter).AsQueryable();
		}

		public TEntity GetValue(Expression<Func<TEntity, bool>> filter = null)
		{
			return filter == null ?
				context.Set<TEntity>().SingleOrDefault() :
				context.Set<TEntity>().Where(filter).SingleOrDefault();
		}

		public void Update(TEntity entity)
		{
			var upadetedEntity = context.Entry(entity);
			upadetedEntity.State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}
