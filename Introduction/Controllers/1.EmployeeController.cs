using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers.Employee_1
{

    [ApiController]   //This is kind of attribute where asp.net core server thinks that class is able to create the endpoints/resources.

    [Route("api/[Controller]")]

    // ControllerBase is a class which is useful to prepare the status to the responses.
    public class EmployeeV1Controller : ControllerBase   
    {
        // to prepare the endpoints, we should make sure that, to design with the asynchronous calls.
        public EmployeeV1Controller() { }

        // https://localhost:7287/api/EmployeeV1/GetEmployeesList
        [HttpGet]  // if the request comes, data fetch then desing with httpget
        [Route("GetEmployeesList")]
        public async Task<IActionResult> GetEmployeesList()
        {


            string EmpName = "PEter";


            var employeesList = await GetEmployees();  // given the resoponse to the guy who asked the data


            var count = employeesList.Where(x => x == EmpName).Count();


            if (count == 0)
            {
                return NotFound($"No employees found with the name of {EmpName} ");   // 404 Not found
            }
            return Ok(new List<string> { "JOHN", "PEter" });  // 200 success code . json
        }

        private async Task<List<string>> GetEmployees()
        {
            await Task.Delay(2000);
            return _store();
        }
        private List<string> _store()
        {

            return new List<string> { "JOHN", "PEter", "PEter" };
        }

        //[HttpGet]  // if the request, to fetch the data, we use httpget
        //[Route("GetEmployeeList")]
        //public async Task<IActionResult> GetEmployeeList()
        //{
        //    await Task.Delay(3000);
        //    return Ok(new List<string> {"Conrad", "Fisher"});
        //}

        [HttpGet]
        [Route("GetEmployeeList")]
        public IActionResult GetEmployeeList()
        {
            return Ok(new List<string> { "Conrad", "Fisher" });
        }

        [HttpGet]
        [Route("GetEmployeeList1")]
        public IActionResult GetEmployeeList1()
        {
            return Ok(new List<string> { "Conrad", "Fisher" });
        }

    }


}
//https://localhost:7287/api/EmployeeV1/GetEmployeeList


//public class employee
//{ 
//    public string? name { get; set; }
    
//}
//public class EployeeController : ControllerBase
//{
//   List<employee> Employees = new List<employee>
//   {
//       new employee{name = "John"},
//       new employee{name = "narmada"},
//       new employee{name = "swapna"}
//   };

//}





