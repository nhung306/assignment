namespace DataAccess.Entities
{
	public abstract class BaseEntity
	{
		public BaseEntity()
		{
		}
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}