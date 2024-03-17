using System;
using System.Collections.Generic;

namespace OnlineQuizApi.DataBaseModel;

public partial class QuizDetail
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long CategoryId { get; set; }

    public short NoOfQuestion { get; set; }

    public short MarkPerQuestion { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual QuizCategory Category { get; set; } = null!;

    public virtual QuizInstructionDetail? QuizInstructionDetail { get; set; }

    public virtual QuizQuestionDetail? QuizQuestionDetail { get; set; }
}
