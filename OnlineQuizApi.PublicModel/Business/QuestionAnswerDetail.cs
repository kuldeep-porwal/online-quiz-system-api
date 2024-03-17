namespace OnlineQuizApi.PublicModel.Business;

public partial class QuestionAnswerDetail
{
    public long Id { get; set; }

    public long QuestionId { get; set; }

    public long OptionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}
