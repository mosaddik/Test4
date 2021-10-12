using Manager.Interface;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.Models;

namespace Manager.Implementation
{
    public class UserManager : IUserManager
    {

        private IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public object ActiveOrDeactive(long userId)
        {
            throw new NotImplementedException();
        }

        public object ChangePassword(long userId, string password)
        {
            throw new NotImplementedException();
        }

        public object CreateUser(User user)
        {
            try
            {
                this.userRepository.Add(user);
                this.userRepository.SaveChanges();
                var result = new { success = true, successMessage = "User Added sccessfully !" };
                return result;
            }
            catch (Exception ex)
            {

                var result = new { success = false, errorMessage = ex.GetBaseException().Message };
                return result;
            }
        }

        public object GetAllUser()
        {
            try
            {
                IEnumerable<User>  userlist = this.userRepository.GetAll();
                var result = new { success = true, data = userlist };
                return result;
            }
            catch (Exception ex)
            {

                var result = new { success = false, errorMessage = ex.Message };
                return result;
            }
        }

        public object UpdateUser(long userId, string fristName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
