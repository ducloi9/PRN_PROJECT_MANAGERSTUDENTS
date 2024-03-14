using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class Department
    {
        public Department()
        {
            Classes = new HashSet<Class>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
