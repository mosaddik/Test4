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
    public class UserRoleApiController : ControllerBase
    {
        private   IUserRoleManager userRoleManager ;

        public UserRoleApiController(IUserRoleManager userRoleManager)
        {
            this.userRoleManager = userRoleManager;
        }

        [HttpPost]
        public Object Create(string userRole)
        {
            return this.userRoleManager.Create(userRole);
        }

        [HttpGet]
        public Object Get()
        {
            return this.userRoleManager.GetAllUserRole();
        }

    }
}
