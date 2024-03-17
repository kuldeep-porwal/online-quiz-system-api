using Microsoft.AspNetCore.Mvc;
using OnlineQuizApi.Business.Interface;
using OnlineQuizApi.Framework.Controllers;
using OnlineQuizApi.PublicModel.Request;
using OnlineQuizApi.PublicModel.Response;

namespace OnlineQuizApi.Controllers
{
    [Route("api/[controller]")]
    public class QuizCategoryController : BaseApiController
    {
        private readonly IQuizCategoryBiz _quizCategoryBiz;

        public QuizCategoryController(IQuizCategoryBiz quizCategoryBiz)
        {
            _quizCategoryBiz = quizCategoryBiz;
        }

        [HttpGet]
        public async Task<QuizCategoryPaginationResponse> GetAsync([FromQuery] QuizCategoryPaginationRequest request)
        {
            return await _quizCategoryBiz.GetAsync(request);
        }

        [HttpGet("{categoryId}")]
        public async Task<SingleQuizCategoryWithDetailResponse> GetByIdAsync([FromRoute] long categoryId)
        {
            return await _quizCategoryBiz.GetByIdAsync(categoryId);
        }
    }
}
