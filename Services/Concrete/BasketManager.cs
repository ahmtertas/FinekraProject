using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace Services.Concrete
{
	public class BasketManager : IBasketService
	{
		private readonly IBasketDal _basketDal;
		public BasketManager(IBasketDal basketDal)
		{
			_basketDal = basketDal;
		}

		public void Delete(Basket Basket)
		{
			_basketDal.Delete(Basket);
		}

		public IQueryable<Basket> GetAllList(int id)
		{
			return _basketDal.GetAll(basket => basket.IsCompleted == false && basket.UserDetailId == id).Include(p => p.UserDetail).Include(t => t.BasketItems);
		}

		public IQueryable<Basket> GetWithSubData(int id)
		{
			return _basketDal.GetAll(basket => basket.BasketId == id).Include(p => p.UserDetail).Include(t => t.BasketItems);
		}

		public Basket GetBasket(int id)
		{
			return _basketDal.GetValue(basket => basket.BasketId == id);
		}

		public Basket GetUserBasket(int id)
		{
			return _basketDal.GetValue(basket => basket.IsCompleted == false && basket.UserDetailId == id);
		}

		public void Insert(Basket basket)
		{
			_basketDal.Insert(basket);
		}

		public void Update(Basket Basket)
		{
			_basketDal.Update(Basket);
		}
	}
}
