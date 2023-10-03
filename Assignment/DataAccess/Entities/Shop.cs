using System.ComponentModel.DataAnnotations;

namespace Assignment.DataAccess.Entities
{
	public class Shop : BaseEntity
    {
        public Shop()
        {
        }
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Location { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

