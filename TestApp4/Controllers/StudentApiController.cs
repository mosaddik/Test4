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
    public class StudentApiController : ControllerBase
    {
        private IStudentManager studentManager;
        public StudentApiController(IStudentManager studentManager)
        {
            this.studentManager = studentManager;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return this.studentManager.GetAllStudents();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(string studentName)
        {
            this.studentManager.EnrolNewStudent(studentName);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //this.studentManager.EnrolNewStudent(studentName);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
