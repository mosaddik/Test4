using Repository.Interface;
using Repository.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp4.conext;
using TestApp4.Models;

namespace Repository.Implementation
{
    public class UserRepository : Repository<User>,IUserRepository
    {

        private AppDbContext _db;

        public UserRepository(AppDbContext db):base(db)
        {

        }




    }
}
