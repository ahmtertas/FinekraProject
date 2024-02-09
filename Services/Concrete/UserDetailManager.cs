using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class UserDetailManager : IUserDetailService
	{
		private readonly IUserDetailDal _userDetailDal;
		public UserDetailManager(IUserDetailDal UserDetail)
		{
			_userDetailDal = UserDetail;
		}

		public void Delete(UserDetail UserDetail)
		{
			_userDetailDal.Delete(UserDetail);
		}

		public IQueryable<UserDetail> GetAllList()
		{
			return _userDetailDal.GetAll();
		}

		public UserDetail GetUserDetail(int id)
		{
			return _userDetailDal.GetValue(UserDetail => UserDetail.UserDetailId == id);
		}

		public void Insert(UserDetail UserDetail)
		{
			_userDetailDal.Insert(UserDetail);
		}

		public void Update(UserDetail UserDetail)
		{
			_userDetailDal.Update(UserDetail);
		}
	}
}
