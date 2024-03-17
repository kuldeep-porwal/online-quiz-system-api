namespace OnlineQuizApi.PublicModel.Business;

public partial class QuestionDetail
{
    public long Id { get; set; }

    public string Question { get; set; } = null!;

    public short TypeOfQuestion { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public long QuestionCategoryId { get; set; }
}
