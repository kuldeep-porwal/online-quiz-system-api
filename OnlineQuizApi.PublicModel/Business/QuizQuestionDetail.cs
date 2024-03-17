namespace OnlineQuizApi.PublicModel.Business;

public partial class QuizQuestionDetail
{
    public long Id { get; set; }

    public long QuizId { get; set; }

    public long QuestionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}
