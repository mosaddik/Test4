using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.Models;

namespace Manager.Interface
{
    public interface IUserManager
    {
        public object CreateUser(User user);
        public object UpdateUser(long userId, string fristName, string lastName);
        public object ChangePassword(long userId, string password);
        public object ActiveOrDeactive(long userId);
        public object GetAllUser();
    }
}
