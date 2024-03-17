using OnlineQuizApi.Framework.Models.Request;

namespace OnlineQuizApi.PublicModel.Request
{
    public class QuizCategoryPaginationRequest : BasePaginationRequest
    {
        public QuizCategoryPaginationRequest() : base(1, 10)
        { }
    }
}
