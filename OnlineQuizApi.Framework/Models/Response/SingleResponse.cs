namespace OnlineQuizApi.Framework.Models.Response
{
    public class SingleResponse<T> : BaseErrorResponse
    {
        public T? Item { get; set; }
    }
}
