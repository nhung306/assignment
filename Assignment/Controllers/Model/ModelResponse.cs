using System;
namespace Assignment.Controllers.Model
{
	public class ModelResponse<T> : BaseResponse<T>
	{
		public ModelResponse()
		{
		}
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}

