using Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
	public class Brand : IEntity
	{
		[Key]
		public int BrandId { get; set; }
		public string BrandName { get; set; }
		public string Description { get; set; }
		public ICollection<Perfume> Perfume { get; set; }
	}
}
