using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Introduction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController
    {
        [HttpGet]
        [Route("GetEmpName")]
        public string GetEmpName()
        {
            return "Isabel";
        }

        [HttpGet]
        [Route("GetManagerName")]
        public string GetManagerName()
        {
            return "Conrad";
        }

        //https://localhost:7287/Employees/GetEmpName
    }
}
