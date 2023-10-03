
namespace Assignment.Controllers.Model
{
	public class BaseResponse<T>
	{
		public BaseResponse()
		{
		}
		public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; }
		       
    }
}

