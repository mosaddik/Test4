using Models.Models;
using Repository.Interface;
using Repository.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.conext;

namespace Repository.Implementation
{
    public class CourseRepository : Repository<Course> , ICourseRepository
    {
        private AppDbContext _db;
        public CourseRepository(AppDbContext db) : base(db)
        {

        }
    }
}
