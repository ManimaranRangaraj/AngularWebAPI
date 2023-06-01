using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWebAPI.Models;

[Table("Department")]
public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    //public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
