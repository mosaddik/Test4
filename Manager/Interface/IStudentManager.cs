using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface IStudentManager
    {
        public bool EnrolNewStudent(string studentName);
        public bool UpdateStudentDetails(int studentId , Students students);
        public IEnumerable<Students> GetAllStudents();
    }
}
