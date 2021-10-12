using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Students>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
