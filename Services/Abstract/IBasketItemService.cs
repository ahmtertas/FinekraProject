using Entity.Concrete;

namespace Services.Abstract
{
	public interface IBasketItemService
	{
		IQueryable<BasketItem> GetAllList();
		BasketItem GetBasketItem(int id);
		void Insert(BasketItem basketItem);
		void Update(BasketItem basketItem);
		void Delete(BasketItem basketItem);
		void Delete(int id);
	}
}
