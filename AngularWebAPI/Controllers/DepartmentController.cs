using AngularWebAPI.Models;
using AngularWebAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public DepartmentController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
        }
        [HttpGet("GetDepartment")]
        //[Route]
        public IActionResult Get()
        {
            return Ok(_employeeRepo.DepartmentRepo.GetDepartment());
        }
        [HttpPost("AddDepartment")]
        //[Route]
        public IActionResult Post(Department dep)
        {
            var result = _employeeRepo.DepartmentRepo.AddDepartment(dep);
            //if (result.DepartmentId == 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            //}
            return new JsonResult("Added Successfully");
        }
        [HttpPut("UpdateDepartment")]
        //[Route]
        public IActionResult Put(Department dep)
        {
            _employeeRepo.DepartmentRepo.UpdateDepartment(dep);
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("DeleteDepartment/{id}")]
        //[Route]
        public IActionResult Delete(int id)
        {
            if (_employeeRepo.DepartmentRepo.DeleteDepartment(id))
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
