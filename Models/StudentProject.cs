using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class StudentProject
    {
        public int ProjectId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? TeacherId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
