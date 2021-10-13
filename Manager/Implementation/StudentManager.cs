using Manager.Interface;
using Models.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Implementation
{
    public class StudentManager : IStudentManager
    {
        private IStudentRepository studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool EnrolNewStudent(string studentName)
        {
            if (studentName == null)
                throw new ArgumentNullException("student Name can not be null !");

            if (studentName == string.Empty)
                throw new ArgumentException("student Name can not be Emety !");

            var student = new Students()
            {
                StudentName = studentName,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                IsActive = true
            };

            this.studentRepository.Add(student);
            return this.studentRepository.SaveChanges();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return this.studentRepository.GetAll();
        }

        public bool UpdateStudentDetails(int studentId, Students students)
        {
            throw new NotImplementedException();
        }
    }
}
