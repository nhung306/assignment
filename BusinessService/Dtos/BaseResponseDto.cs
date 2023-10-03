namespace BusinessService.Dtos
{
    public class BaseResponseDto<T>
    {
        public BaseResponseDto()
        {
        }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; }

    }
}
