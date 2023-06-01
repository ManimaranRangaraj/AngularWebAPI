using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWebAPI.Models;

[Table("Student")]
public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? Course { get; set; }

    public string? Specialization { get; set; }

    public string? Percentage { get; set; }

    public int? DepartmentId { get; set; }

    //public virtual Department? Department { get; set; }
}
