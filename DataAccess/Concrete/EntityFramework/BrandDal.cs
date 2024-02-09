using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class BrandDal : EfEntityRepositoryBase<Brand>, IBrandDal
	{
		public BrandDal(FinekraContext finekraContext) : base(finekraContext)
		{

		}
	}
}
