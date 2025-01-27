using System;
using System.Collections.Generic;

namespace Johan_Hansson_SUT24_Labb3.Models;

public partial class Class
{
    public int Id { get; set; }

    public string? ClassName { get; set; }

    public int TeacherStaffId { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual Staff TeacherStaff { get; set; } = null!;
}
