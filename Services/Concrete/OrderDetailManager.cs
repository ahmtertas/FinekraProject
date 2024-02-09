using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class OrderDetailManager : IOrderDetailService
	{
		private readonly IOrderDetailDal _orderDetailDal;
		public OrderDetailManager(IOrderDetailDal orderDetailDal)
		{
			_orderDetailDal = orderDetailDal;
		}

		public void Delete(OrderDetail OrderDetail)
		{
			_orderDetailDal.Delete(OrderDetail);
		}

		public IQueryable<OrderDetail> GetAllList()
		{
			return _orderDetailDal.GetAll();
		}

		public OrderDetail GetOrderDetail(int id)
		{
			return _orderDetailDal.GetValue(OrderDetail => OrderDetail.PerfumeId == id);
		}

		public void Insert(OrderDetail OrderDetail)
		{
			_orderDetailDal.Insert(OrderDetail);
		}

		public void Update(OrderDetail OrderDetail)
		{
			_orderDetailDal.Update(OrderDetail);
		}
	}
}
