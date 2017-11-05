using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.WebAPI.Models.Courses;

namespace ContosoUniversity.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Courses")]
    public class CoursesController : Controller
    {
        [HttpGet]
        [Produces(typeof(IEnumerable<CourseApiModel>))]
        public IActionResult GetAll()
        {
            return Ok();
        }


        [HttpGet]
        [Produces(typeof(IEnumerable<CourseApiModel>))]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
    }
}