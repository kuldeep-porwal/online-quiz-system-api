namespace OnlineQuizApi.DataBaseModel;

public partial class QuestionOptionDetail
{
    public long Id { get; set; }

    public long QuestionId { get; set; }

    public string Option { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual QuestionDetail Question { get; set; } = null!;

    public virtual ICollection<QuestionAnswerDetail> QuestionAnswerDetails { get; set; } = [];
}
