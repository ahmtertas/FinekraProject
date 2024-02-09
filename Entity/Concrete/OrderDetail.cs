using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class OrderDetail : IEntity
	{
		[Key]
		public int OrderDetailId { get; set; }

		[ForeignKey("Order")]
		public int OrderId { get; set; }
		public Order Order { get; set; }

		[ForeignKey("Perfume")]
		public int PerfumeId { get; set; }
		public Perfume Perfume { get; set; }

		public decimal Price { get; set; }
		public decimal Count { get; set; }
	}
}
