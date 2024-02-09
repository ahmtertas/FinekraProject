using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class UserDetailDal : EfEntityRepositoryBase<UserDetail>, IUserDetailDal
	{
		public UserDetailDal(FinekraContext context) : base(context)
		{

		}
	}
}
