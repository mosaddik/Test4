using Manager.Interface;
using Models.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Implementation
{
    public class CourseManager : ICourseManager
    {
        private ICourseRepository CourseRepository;

       
        public CourseManager(ICourseRepository CourseRepository)
        {
            this.CourseRepository = CourseRepository;
        }
        public bool ActiveOrDeactive(long userId)
        {
            throw new NotImplementedException();
        }

        public bool Create(Course user)
        {
            var result = new List<Students>
                {
                    new Students
                    {
                        StudentName = "Akram",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        IsActive = true
                    }
            };
                
            var course = new Course
            {
                CourseName = "AFM",
                Students = result
            };

            this.CourseRepository.Add(course);
            this.CourseRepository.SaveChanges();
            return true;

        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(long courseId, string fristName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
