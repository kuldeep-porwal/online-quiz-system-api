using OnlineQuizApi.Business.Interface;
using OnlineQuizApi.PublicModel.Request;
using OnlineQuizApi.PublicModel.Response;

namespace OnlineQuizApi.Business.Implementation
{
    public class QuizCategoryBiz : IQuizCategoryBiz
    {
        public Task<QuizCategoryPaginationResponse> GetAsync(QuizCategoryPaginationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<SingleQuizCategoryWithDetailResponse> GetByIdAsync(long categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
