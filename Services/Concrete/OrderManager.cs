using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;
		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public void Delete(Order order)
		{
			_orderDal.Delete(order);
		}

		public IQueryable<Order> GetAllList()
		{
			return _orderDal.GetAll();
		}

		public Order GetByUserId(int userId)
		{
			return _orderDal.GetValue(order => order.UserDetailId == userId);
		}

		public Order GetOrder(int id)
		{
			return _orderDal.GetValue(order => order.OrderId == id);
		}

		public void Insert(Order order)
		{
			_orderDal.Insert(order);
		}

		public void Update(Order order)
		{
			_orderDal.Update(order);
		}
	}
}
