using OnlineQuizApi.Framework.Models.Common;

namespace OnlineQuizApi.Framework.Models.Response
{
    public class BaseErrorResponse : BaseResponse
    {
        public BaseErrorResponse()
        {
            Errors = [];
        }
        public List<Error> Errors { get; set; }
    }
}
