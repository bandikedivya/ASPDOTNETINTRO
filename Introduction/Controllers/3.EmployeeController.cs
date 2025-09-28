using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;




// DI , GUID , static class , angular , headers , params , body(post) , put , pathc , delete





namespace Introduction.Controllers.Employees_2
{

    [ApiController]
    [Route("api/[Controller]")]

    public class EmployeeV3Controller : ControllerBase
    {
        public EmployeeV3Controller() { }
    
    private async Task<List<Employee>> GetEmployees()
        {
            await Task.Delay(2000);
            return _store();
        }


        private List<Employee> _store()
        {
            return new List<Employee>()
                {
                    new Employee() { EmpId = 1, EmpName = "Michel", EmpLocation = "New York", EmpSalary = 20000.89 },
                    new Employee() { EmpId = 2, EmpName = "Sarah",  EmpLocation = "London",   EmpSalary = 25000.50 },
                    new Employee() { EmpId = 3, EmpName = "Ravi",   EmpLocation = "Bangalore",EmpSalary = 35000.00 },
                    new Employee() { EmpId = 4, EmpName = "Emily",  EmpLocation = "New York", EmpSalary = 30000.75 },
                    new Employee() { EmpId = 5, EmpName = "John",   EmpLocation = "New York", EmpSalary = 29000.40 }
                };
        }
        //DTO
        //https://localhost:7287/api/EmployeeV3/GetEmployeesListByLocatinAndSalaryWithMultiQueryParamsWithDTO?empname=John&location=New%20York&salary=28000

        [HttpGet]  // if the request is data fetch then desing with httpget
        [Route("GetEmployeesListByLocatinAndSalaryWithMultiQueryParamsWithDTO")]
        public async Task<IActionResult> GetEmployeesListByLocatinAndSalaryWithQueryWithDTO(
            [FromQuery] EmployeeDTO employee)
        {
            var employeesList = await GetEmployees();  // given the resoponse to the guy who asked the data
            var result = employeesList.Where(x => x.EmpLocation == employee.Location && x.EmpSalary > employee.Salary && x.EmpName == employee.EmpName);
            if (!result.Any())
            {
                return NotFound($"No employees found with salary and location {employee.Location} - {employee.Salary} ");   // 404 Not found
            }
            else
            {
                return Ok(result);
            }
            //  return Ok(new List<string> { "JOHN", "PEter" });  // 200 success code . json
        }

        // Post --  used to insert the data(from the body) and also filter & we can also trim the data.

        //https://localhost:7287/api/EmployeeV3/GetEmployeesList_filter
        [HttpPost]
        [Route("GetEmployeesList_filter")]
        public async Task<IActionResult> GetEmployeesList_filter(
           [FromBody] EmployeeDTO employee)
        {
            var employeesList = await GetEmployees();  // given the resoponse to the guy who asked the data
            var result = employeesList.Where(x => x.EmpLocation == employee.Location && x.EmpSalary > employee.Salary && x.EmpName == employee.EmpName);
            if (!result.Any())
            {
                return NotFound($"No employees found with salary and location {employee.Location} - {employee.Salary} ");   // 404 Not found
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
public class EmployeeDTO
{
    public string EmpName { get; set; }
    public string Location { get; set; }
    public double Salary { get; set; }
}
