using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            StudentProjects = new HashSet<StudentProject>();
        }

        public int TeacherId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<StudentProject> StudentProjects { get; set; }
    }
}
