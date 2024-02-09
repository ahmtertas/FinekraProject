using Entity.Concrete;

namespace Services.Abstract
{
	public interface IOrderService
	{
		IQueryable<Order> GetAllList();
		Order GetOrder(int id);
		void Insert(Order order);
		void Update(Order order);
		void Delete(Order order);
		Order GetByUserId(int userId);
	}
}
