namespace OnlineQuizApi.DataBaseModel;

public partial class QuestionCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<QuestionDetail> QuestionDetails { get; set; } = [];
}
