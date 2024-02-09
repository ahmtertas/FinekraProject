using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class OrderDal : EfEntityRepositoryBase<Order>, IOrderDal
	{
		public OrderDal(FinekraContext context) : base(context) { }

	}
}
