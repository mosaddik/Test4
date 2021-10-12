using Manager.Interface;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp4.Models;

namespace Manager.Implementation
{
    public class UserRoleManager : IUserRoleManager
    {
        private IUserRoleRepository userroleRepository;

        public UserRoleManager(IUserRoleRepository userroleRepository)
        {
            this.userroleRepository = userroleRepository;
        }
        public object ActiveOrDeactive(long userId)
        {
            throw new NotImplementedException();
        }

        public object Create(string userName)
        {
            try
            {
                var ob = new UserRole() { 
                    
                    RoleName = userName ,
                    UpdatedOn = DateTime.Now,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };
                this.userroleRepository.Add(ob);
                this.userroleRepository.SaveChanges();
                var result = new { success = true, successMessage = "User Added sccessfully !" };
                return result;

            }
            catch (Exception ex)
            {

                var result = new { success = true, errorMessage = ex.Message };
                return result;
            }
        }

        public object GetAllUserRole()
        {
            try
            {
                var data = this.userroleRepository.GetAll();
                var result = new { success = true , data = data };
                return result;

            }
            catch (Exception ex)
            {

                var result = new { success = false , errorMessage = ex.Message };
                return result;
            }
        }

        public object Update(long userId, string fristName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
