using Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private IUserManager userManager;

        public UserApiController(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public Object Get()
        {
            return this.userManager.GetAllUser();
        }

        [HttpPost]
        public object Create(string Email , string userName,string password)
        {
            var user = new Models.User()
            {
                UserName = userName,
                Password = password,
                EmailAddress = Email,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                RoleId = 1
            };

            var createuser = userManager.CreateUser(user);
            return createuser;
        }

    }
}
