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

        [HttpGet]  // if the request is data fetch then desing with httpget
        [Route("GetEmployeesList")]
        public async Task<IActionResult> GetEmployeesList()
        {


            string EmpName = "Madan";


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

        [HttpGet]  // if the request, to fetch the data, we use httpget
        [Route("GetEmployeeList")]
        public async Task<IActionResult> GetEmployeeList()
        {
            await Task.Delay(3000);
            return Ok(new List<string> {"Conrad", "Fisher"});
        }
    }
}
//https://localhost:7287/api/EmployeeV1/GetEmployeeList