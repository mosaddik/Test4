using Manager.Implementation;
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CourseApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CourseApiController>
        [HttpPost]
        public void Post()
        {
            this.courseManager.Create(null);
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
