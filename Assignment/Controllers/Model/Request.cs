using System;
namespace Assignment.Controllers.Model
{
	public class Request
	{
		public Request()
		{
		}
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }
    }
}

