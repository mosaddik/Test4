using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface IStudentManager
    {
        public bool Create(Students user);
        public bool Update(long courseId, string fristName, string lastName);
        public bool ActiveOrDeactive(long userId);
        public object GetAll();
    }
}
