namespace Assignment.Models
{
    public class RequestModel
    {
        public RequestModel()
        {
        }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }
    }
}

