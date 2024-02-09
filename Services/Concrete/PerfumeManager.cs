using DataAccess.Abstract;
using Entity.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
	public class PerfumeManager : IPerfumeService
	{
		private readonly IPerfumeDal _perfumeDal;
		public PerfumeManager(IPerfumeDal perfumeDal)
		{
			_perfumeDal = perfumeDal;
		}

		public void Delete(Perfume perfume)
		{
			_perfumeDal.Delete(perfume);
		}

		public IQueryable<Perfume> GetAllList()
		{
			return _perfumeDal.GetAll();
		}

		public Perfume GetPerfume(int id)
		{
			return _perfumeDal.GetValue(perfume => perfume.PerfumeId == id);
		}

		public void Insert(Perfume perfume)
		{
			_perfumeDal.Insert(perfume);
		}

		public void Update(Perfume perfume)
		{
			_perfumeDal.Update(perfume);
		}
	}
}
