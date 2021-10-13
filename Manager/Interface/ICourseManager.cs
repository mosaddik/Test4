using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface ICourseManager
    {
        public bool Create(string courseName);
        public bool UpdateCourseName(long courseId , string courseName);
        public IEnumerable<Course> GetAll();
    }
}
