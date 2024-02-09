using Entity.Abstract;

namespace Entity.Concrete
{
	public class UserDetail : IEntity
	{
		public int UserDetailId { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }

		public ICollection<Order> Order { get; set; }
		public ICollection<Basket> Basket { get; set; }
	}
}