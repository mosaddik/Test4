using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface ICourseManager
    {
        public bool Create(Course user);
        public bool Update(long courseId , string fristName, string lastName);
        public bool ActiveOrDeactive(long userId);
        public object GetAll();
    }
}
