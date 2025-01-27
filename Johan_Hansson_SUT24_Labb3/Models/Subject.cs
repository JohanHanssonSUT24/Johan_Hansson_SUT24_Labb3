using System;
using System.Collections.Generic;

namespace Johan_Hansson_SUT24_Labb3.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
