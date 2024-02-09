using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class BasketDal : EfEntityRepositoryBase<Basket>, IBasketDal
	{
		public BasketDal(FinekraContext finekraContext) : base(finekraContext)
		{

		}
	}
}
