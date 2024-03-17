namespace OnlineQuizApi.Framework.Models.Request
{
    public class BasePaginationRequest : BaseRequest
    {
        public BasePaginationRequest() { }
        public BasePaginationRequest(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
