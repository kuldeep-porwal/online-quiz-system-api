using System;
using System.Collections.Generic;

namespace OnlineQuizApi.DataBaseModel;

public partial class QuizSubInstructionDetail
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public long QuizInstructionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual QuizInstructionDetail IdNavigation { get; set; } = null!;
}
