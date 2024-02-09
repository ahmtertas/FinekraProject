using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class OrderDetailDal : EfEntityRepositoryBase<OrderDetail>, IOrderDetailDal
	{
		public OrderDetailDal(FinekraContext context) : base(context) { }
	}
}
