using Entity.Concrete;

namespace Services.Abstract
{
	public interface IPerfumeService
	{
		IQueryable<Perfume> GetAllList();
		Perfume GetPerfume(int id);
		void Insert(Perfume perfume);
		void Update(Perfume perfume);
		void Delete(Perfume perfume);
	}
}
