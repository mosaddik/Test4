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
     

        public bool Create(string courseName)
        {

            if (courseName == null)
                throw new ArgumentNullException("Course Name can not be null !");

            //if (courseName == string.Empty )
            //    throw new ArgumentException("Course Name can not be Emety !");

            var aNewCourse = new Course() { CourseName = courseName };

            this.CourseRepository.Add(aNewCourse);
            return this.CourseRepository.SaveChanges();

        }

        public IEnumerable<Course> GetAll()
        {
            return this.CourseRepository.GetAll();
        }

        public bool UpdateCourseName(long courseId, string courseName)
        {
            if (courseName == null)
                throw new ArgumentNullException("Course Name can not be null !");

            if (courseName == string.Empty)
                throw new ArgumentException("Course Name can not be Emety !");

            var aCourse = this.CourseRepository.GetById(courseId);
            aCourse.CourseName = courseName;
            this.CourseRepository.Update(aCourse);
            return this.CourseRepository.SaveChanges();
        }
    }
}
