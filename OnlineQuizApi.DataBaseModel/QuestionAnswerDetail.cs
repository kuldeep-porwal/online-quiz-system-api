using System;
using System.Collections.Generic;

namespace OnlineQuizApi.DataBaseModel;

public partial class QuestionAnswerDetail
{
    public long Id { get; set; }

    public long QuestionId { get; set; }

    public long OptionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual QuestionOptionDetail Option { get; set; } = null!;

    public virtual QuestionDetail Question { get; set; } = null!;
}
