namespace OnlineQuizApi.Framework.Models.Response
{
    public class PaginationResponse<T> : BaseErrorResponse
    {
        public int CurrentPage { get; set; } = 0;
        public int CurrentPageSize { get; set; } = 10;
        public int TotalItems { get; set; }
        public IReadOnlyList<T> Items { get; set; } = [];
    }
}
