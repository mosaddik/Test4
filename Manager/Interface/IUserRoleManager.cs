using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface IUserRoleManager    
    {
        public object Create(string userName);
        public object Update(long userId, string fristName, string lastName);
        public object ActiveOrDeactive(long userId);
        public object GetAllUserRole();
    }
}
