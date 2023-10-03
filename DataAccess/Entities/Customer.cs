using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
	public class Customer : BaseEntity
	{
		public Customer()
		{
		}
        public int ID { get; set; }
        [MaxLength(250)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
	}
}

