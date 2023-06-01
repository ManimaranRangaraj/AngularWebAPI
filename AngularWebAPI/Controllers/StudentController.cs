using AngularWebAPI.Models;
using AngularWebAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public StudentController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
        }
        [HttpGet("GetStudent")]
        //[Route]
        public IActionResult Get()
        {
            return Ok(_employeeRepo.StudentRepo.GetStudent());
        }
        [HttpPost("AddStudent")]
        //[Route]
        public IActionResult Post(Student stud)
        {
            var result = _employeeRepo.StudentRepo.AddStudent(stud);
            //if (result.StudentId == 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            //}
            return new JsonResult("Added Successfully");
        }
        [HttpPut("UpdateStudent")]
        //[Route]
        public IActionResult Put(Student stud)
        {
            _employeeRepo.StudentRepo.UpdateStudent(stud);
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("DeleteStudent/{id}")]
        //[Route]
        public JsonResult Delete(int id)
        {
            var result = _employeeRepo.StudentRepo.DeleteStudent(id);
            if (result)
            {
                return new JsonResult("Deleted Successfully");
            }
            else
            {
                return new JsonResult("No Record to Delete");
            }
        }
    }
}
