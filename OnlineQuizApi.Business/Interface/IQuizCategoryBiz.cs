using OnlineQuizApi.PublicModel.Request;
using OnlineQuizApi.PublicModel.Response;

namespace OnlineQuizApi.Business.Interface
{
    public interface IQuizCategoryBiz
    {
        Task<QuizCategoryPaginationResponse> GetAsync(QuizCategoryPaginationRequest request);
        Task<SingleQuizCategoryWithDetailResponse> GetByIdAsync(long categoryId);
    }
}
