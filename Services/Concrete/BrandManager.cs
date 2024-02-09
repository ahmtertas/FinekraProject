using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class BrandManager : IBrandService
	{
		private readonly IBrandDal _brandDal;
		public BrandManager(IBrandDal BrandDal)
		{
			_brandDal = BrandDal;
		}

		public void Delete(Brand Brand)
		{
			_brandDal.Delete(Brand);
		}

		public IQueryable<Brand> GetAllList()
		{
			return _brandDal.GetAll();
		}

		public Brand GetBrand(int id)
		{
			return _brandDal.GetValue(brand => brand.BrandId == id);
		}

		public void Insert(Brand Brand)
		{
			_brandDal.Insert(Brand);
		}

		public void Update(Brand Brand)
		{
			_brandDal.Update(Brand);
		}
	}
}
