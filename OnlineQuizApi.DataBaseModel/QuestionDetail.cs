﻿namespace OnlineQuizApi.DataBaseModel;

public partial class QuestionDetail
{
    public long Id { get; set; }

    public string Question { get; set; } = null!;

    public short TypeOfQuestion { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public long QuestionCategoryId { get; set; }

    public virtual ICollection<QuestionAnswerDetail> QuestionAnswerDetails { get; set; } = [];

    public virtual QuestionCategory QuestionCategory { get; set; } = null!;

    public virtual ICollection<QuestionOptionDetail> QuestionOptionDetails { get; set; } = [];

    public virtual ICollection<QuizQuestionDetail> QuizQuestionDetails { get; set; } = [];
}
