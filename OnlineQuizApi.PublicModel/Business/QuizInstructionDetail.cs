namespace OnlineQuizApi.PublicModel.Business;

public partial class QuizInstructionDetail
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public long QuizId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}
