using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentProjects = new HashSet<StudentProject>();
        }

        public int StudentId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public int? DepartmentId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<StudentProject> StudentProjects { get; set; }
    }
}
