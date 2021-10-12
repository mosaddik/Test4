using Repository.Interface;
using Repository.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.conext;
using TestApp4.Models;

namespace Repository.Implementation
{
    public class UserRoleRepository : Repository<UserRole> , IUserRoleRepository
    {
        private AppDbContext _db;
        public UserRoleRepository(AppDbContext db) : base(db)
        {
        }
    }
}
