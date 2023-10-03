using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.DataAccess.Entities
{
	public class Order : BaseEntity
    {
		public Order()
		{
		}

		public int CustomerID { get; set; }

        public int ProductID { get; set; }
        [ForeignKey(nameof(CustomerID))]
		public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }


    }
}

