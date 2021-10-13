using Manager.Implementation;
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApp4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseApiController : ControllerBase
    {
        private ICourseManager courseManager;

        public CourseApiController(ICourseManager courseManager)
        {
            this.courseManager = courseManager;
        }



        // GET: api/<CourseApiController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return this.courseManager.GetAll();
        }

        // GET api/<CourseApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CourseApiController>
        [HttpPost]
        public object Post(string courseName)
        {
            try
            {
                var success = this.courseManager.Create(courseName);
                
                if(success == true)
                    return new { success = true, successMssage = "Course Added Successfully !" };
                
                else
                     return new { success = false, errorMessage = "No rows effected" };

            }
            catch (Exception ex)
            {

                return new { success = false , errorMessage = ex.GetBaseException().Message };
            }
            
        }

        // PUT api/<CourseApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CourseApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
