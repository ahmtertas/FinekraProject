using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class BasketItemManager : IBasketItemService
	{
		private readonly IBasketItemDal _basketItemDal;
		public BasketItemManager(IBasketItemDal basketItemDal)
		{
			_basketItemDal = basketItemDal;
		}

		public void Delete(BasketItem basketItem)
		{
			_basketItemDal.Delete(basketItem);
		}

		public void Delete(int id)
		{
			_basketItemDal.Delete(id);
		}

		public IQueryable<BasketItem> GetAllList()
		{
			return _basketItemDal.GetAll();
		}

		public BasketItem GetBasketItem(int id)
		{
			return _basketItemDal.GetValue(basketItem => basketItem.BasketItemId == id);
		}

		public void Insert(BasketItem basketItem)
		{
			_basketItemDal.Insert(basketItem);
		}

		public void Update(BasketItem basketItem)
		{
			_basketItemDal.Update(basketItem);
		}
	}
}
