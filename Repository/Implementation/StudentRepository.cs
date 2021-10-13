using Models.Models;
using Repository.Interface;
using Repository.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.conext;

namespace Repository.Implementation
{
  
    public class StudentRepository : Repository<Course>, ICourseRepository
    {
        private AppDbContext _db;

        public StudentRepository(AppDbContext db) : base(db)
        {

        }
    }
}
