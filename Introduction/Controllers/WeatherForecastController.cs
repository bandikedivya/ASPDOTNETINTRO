using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Introduction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController: ControllerBase
    {
        [HttpGet]
        [Route("GetEmpName")]
        //public string GetEmpName()
        //{
        //    return "Isabel";
        //}
        //public List<int> GetEmpName()
        //{
        //    return new List<int> { 1,2,3,4,5};
        //}

        //IActionResult is used to get the status of the Api like 404: Not Found, 200: Ok
        // The NotFound and OK are the methods of the IActionResult. To use this should inherit the ControllerBase(class)
        public IActionResult GetEmpName()
        {
            string empname = "Divya";
            if (empname == null)
            {
                return NotFound(new { Message = "Error" });
            }
            return Ok(new { Message = "Employee is Found" });
        }

        [HttpGet]
        [Route("GetManagerName")]
        public string GetManagerName()
        {
            return "Conrad";
        }

        //https://localhost:7287/api/Employees/GetEmpName
    }
}
