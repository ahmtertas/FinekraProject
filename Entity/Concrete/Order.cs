using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }

		[ForeignKey("UserDetail")]
		public int UserDetailId { get; set; }

		public UserDetail? UserDetail { get; set; }
		public string ShipAddress { get; set; }
		public string Phone { get; set; }
		public DateTime OrderDate { get; set; }

		public ICollection<OrderDetail>? OrderDetail { get; set; }

	}
}