using System;
using System.Collections.Generic;

namespace OnlineQuizApi.DataBaseModel;

public partial class QuizCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<QuizDetail> QuizDetails { get; set; } = new List<QuizDetail>();
}
