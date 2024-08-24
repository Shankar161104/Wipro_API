using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Wipro_API_Customer_Service_Model.Repository;
using Wipro_API_Customer_Service_Model.Model;

namespace Wipro_API_Customer_Service_Model.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       
        private readonly ICustomerService icustomerService;

        public CustomerController(ICustomerService _icustomerService)
        {
            icustomerService = _icustomerService;
        }

        [HttpPost("Create")]

        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(icustomerService.CreateCustomer(customer));
        }

        [HttpPost("CustomerList")]

        public ActionResult GetCustomerList()
        {
            return Ok(icustomerService.GetCustomers());
        }

        [HttpPost("SearchCustomerByID")]

        public ActionResult SearchCustomer(int CustomerID)
        {
            return Ok(icustomerService.SearchCustomer(CustomerID));
        }

        [HttpPost("UpdateCustomer")]

        public ActionResult UpdateCustomer(Customer customer)
        {
            return Ok(icustomerService.UpdateCustomer(customer));
        }

        [HttpPost("DeleteCustomer")]

        public ActionResult DeleteCustomer(Customer customer)
        {
            return Ok(icustomerService.DeleteCustomer(customer));
        }








    }
}
