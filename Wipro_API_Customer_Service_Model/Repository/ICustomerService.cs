using Wipro_API_Customer_Service_Model.Model;

namespace Wipro_API_Customer_Service_Model.Repository
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        Customer SearchCustomer(int id);
        int UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
        int DeleteCustomer(Customer customer);
    }
}
