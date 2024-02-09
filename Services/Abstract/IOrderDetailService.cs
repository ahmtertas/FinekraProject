using Entity.Concrete;

namespace Services.Abstract
{
	public interface IOrderDetailService
	{
		IQueryable<OrderDetail> GetAllList();
		OrderDetail GetOrderDetail(int id);
		void Insert(OrderDetail orderDetail);
		void Update(OrderDetail orderDetail);
		void Delete(OrderDetail orderDetail);
	}
}
