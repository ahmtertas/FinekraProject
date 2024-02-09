using Entity.Concrete;

namespace Services.Abstract
{
	public interface IBasketService
	{
		IQueryable<Basket> GetAllList(int id);
		IQueryable<Basket> GetWithSubData(int id);
		Basket GetBasket(int id);
		Basket GetUserBasket(int id);
		void Insert(Basket basket);
		void Update(Basket basket);
		void Delete(Basket basket);
	}
}
