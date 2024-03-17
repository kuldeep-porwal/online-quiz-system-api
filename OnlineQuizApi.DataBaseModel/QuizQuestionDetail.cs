using System;
using System.Collections.Generic;

namespace OnlineQuizApi.DataBaseModel;

public partial class QuizQuestionDetail
{
    public long Id { get; set; }

    public long QuizId { get; set; }

    public long QuestionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual QuizDetail Id1 { get; set; } = null!;

    public virtual QuestionDetail IdNavigation { get; set; } = null!;
}
