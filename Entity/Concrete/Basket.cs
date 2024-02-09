using Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class Basket : IEntity
	{
		[Key]
		public int BasketId { get; set; }

		[ForeignKey("UserDetail")]
		public int UserDetailId { get; set; }
		public UserDetail? UserDetail { get; set; }
		public DateTime CreateDate { get; set; }
		public bool IsCompleted { get; set; }

		public List<BasketItem>? BasketItems { get; set; }
	}
}
