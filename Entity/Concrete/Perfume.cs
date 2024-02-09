using Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class Perfume : IEntity
	{
		public int PerfumeId { get; set; }
		public string PerfumeName { get; set; }
		[ForeignKey("Brand")]
		public int BrandId { get; set; }
		public Brand Brand { get; set; }
		public decimal Price { get; set; }
		public string PhotoPath { get; set; }
		public ICollection<OrderDetail> OrderDetail { get; set; }
	}
}
