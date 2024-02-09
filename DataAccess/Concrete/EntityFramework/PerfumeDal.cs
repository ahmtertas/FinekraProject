using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class PerfumeDal : EfEntityRepositoryBase<Perfume>, IPerfumeDal
	{
		public PerfumeDal(FinekraContext context) : base(context) { }
	}
}
