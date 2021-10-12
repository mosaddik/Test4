using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TestApp4.Models.Base;

namespace Models.Models
{
    public class Students : Entity
    {
        public Students()
        {
            this.Courses = new HashSet<Course>();
        }

        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
