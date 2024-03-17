namespace OnlineQuizApi.PublicModel.Business;

public class QuizCategoryWithDetail : QuizCategory
{
    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}

public class QuizCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;
}
