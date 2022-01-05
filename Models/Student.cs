using System;
using System.Collections.Generic;

namespace Coursework2Comp2001.Models
{
    public partial class Student
    {
        public Student()
        {
            Projects = new HashSet<Project>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
