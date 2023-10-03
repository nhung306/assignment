using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.DataAccess.Entities
{
	public class Product : BaseEntity
    {
		public Product()
		{
		}

        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        [ForeignKey(nameof(Shop))]
        public int? ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual List<Order> Orders { get; set; }
	}
}

