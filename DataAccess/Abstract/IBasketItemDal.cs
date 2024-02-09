using Entity.Concrete;

namespace DataAccess.Abstract
{
	public interface IBasketItemDal : IEntityRepository<BasketItem>
	{
		void Delete(int id);
	}
}
