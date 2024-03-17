using OnlineQuizApi.Framework.ExtensionMethods;
using OnlineQuizApi.Framework.Models.Common;

namespace OnlineQuizApi.Framework.Validators
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Errors = [];
        }

        public bool HasError() => Errors.IsNotEmpty();

        public List<Error> Errors { get; set; }
    }
}