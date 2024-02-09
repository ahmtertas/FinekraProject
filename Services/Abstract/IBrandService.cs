using Entity.Concrete;

namespace Services.Abstract
{
	public interface IBrandService
	{
		IQueryable<Brand> GetAllList();
		Brand GetBrand(int id);
		void Insert(Brand brand);
		void Update(Brand brand);
		void Delete(Brand brand);
	}
}
