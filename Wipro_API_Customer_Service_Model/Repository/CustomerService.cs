using Wipro_API_Customer_Service_Model.EntityFramework;
using Wipro_API_Customer_Service_Model.Model;

namespace Wipro_API_Customer_Service_Model.Repository
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CustomerService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int CreateCustomer(Customer customer)
        {
            applicationDbContext.Add(customer);
            return applicationDbContext.SaveChanges();
        }

        public int DeleteCustomer(Customer customer)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            applicationDbContext.Customers.Remove(customer);
            return applicationDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return applicationDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int id)
        {
            return applicationDbContext.Customers.SingleOrDefault(t => t.CustomerID == id);
        }

        public int UpdateCustomer(Customer customer)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentException("Entity Missing");
            }
            applicationDbContext.Customers.Update(customer);
            return applicationDbContext.SaveChanges();
        }
    }
}
