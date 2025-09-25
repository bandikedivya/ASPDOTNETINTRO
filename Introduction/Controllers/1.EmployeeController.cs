using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers.Employee_1
{

    [ApiController]   //This is kind of attribute where asp.net core server thinks that class is able to create the endpoints/resources.

    // ControllerBase is a class which is useful to prepare the status to the responses.
    public class EmployeeV1Controller : ControllerBase   
    {
        // to prepare the endpoints, we should make sure that, to design with the asynchronous calls.
    }
}
