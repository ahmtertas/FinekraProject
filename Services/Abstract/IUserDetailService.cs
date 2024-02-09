using Entity.Concrete;

namespace Services.Abstract
{
	public interface IUserDetailService
	{
		IQueryable<UserDetail> GetAllList();
		UserDetail GetUserDetail(int id);
		void Insert(UserDetail userDetail);
		void Update(UserDetail userDetail);
		void Delete(UserDetail userDetail);
	}
}
