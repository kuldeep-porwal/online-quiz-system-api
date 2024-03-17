namespace OnlineQuizApi.DataBaseModel;

public partial class QuizInstructionDetail
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public long QuizId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public bool HasSubInstruction { get; set; }

    public string? HeadingTitle { get; set; }

    public virtual QuizDetail Quiz { get; set; } = null!;
}
