using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class Course
    {
        public Course()
        {
            StudentProjects = new HashSet<StudentProject>();
        }

        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        public virtual ICollection<StudentProject> StudentProjects { get; set; }
    }
}
