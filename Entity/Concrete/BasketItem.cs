using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class BasketItem : IEntity
	{
		[Key]
		public int BasketItemId { get; set; }
		[ForeignKey("Basket")]
		public int BasketId { get; set; }

		public Basket? Basket { get; set; }

		[ForeignKey("Perfume")]
		public int PerfumeId { get; set; }

		public Perfume? Perfume { get; set; }

		public decimal Count { get; set; }
		public decimal Price { get; set; }
	}
}
