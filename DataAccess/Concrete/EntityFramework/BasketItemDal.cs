using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class BasketItemDal : EfEntityRepositoryBase<BasketItem>, IBasketItemDal
	{
		FinekraContext _finekraContext;
		public BasketItemDal(FinekraContext finekraContext) : base(finekraContext)
		{
			_finekraContext = finekraContext;
		}

		public void Delete(int id)
		{
			var deletedEntity = context.Entry(id);
			deletedEntity.State = EntityState.Deleted;
			_finekraContext.SaveChanges();
		}
	}
}
