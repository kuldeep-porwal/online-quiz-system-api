namespace OnlineQuizApi.Framework.Validators
{
    public interface IRequestValidator
    {
        Task<ValidationResult> ValidateAsync<T>(T request);
    }
}
