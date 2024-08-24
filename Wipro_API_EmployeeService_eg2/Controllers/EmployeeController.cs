using Microsoft.AspNetCore.Http;
using Wipro_API_EmployeeService_eg2.Model;
using Wipro_API_EmployeeService_eg2.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_EmployeeService_eg2.Repository;

namespace Wipro_API_EmployeeService_eg2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService iemployeeService;


        public EmployeeController(IEmployeeService _iemployeeService)
        {
            iemployeeService = _iemployeeService;
        }

        [HttpPost("Create")]

        public ActionResult CreateEmployee(Employee employee)
        {
            return Ok(iemployeeService.CreateEmployee(employee));
        }

        [HttpPost("EmployeeList")]

        public ActionResult GetEmployeeList()
        {
            return Ok(iemployeeService.GetEmployees());
        }

        [HttpPost("SearchEmployeeByID")]

        public ActionResult SearchEmployee(int EmpID)
        {
            return Ok(iemployeeService.SearchEmployee(EmpID));
        }

        [HttpPost("UpdateEmployee")]

        public ActionResult UpdateEmployee(Employee employee)
        {
            return Ok(iemployeeService.UpdateEmployee(employee));
        }

        [HttpPost("DeleteEmployee")]

        public ActionResult DeleteEmployee(Employee employee)
        {
            return Ok(iemployeeService.DeleteEmployee(employee));
        }


    }
}
