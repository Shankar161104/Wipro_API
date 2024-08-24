using Wipro_API_EmployeeService_eg2.Model;
using Wipro_API_EmployeeService_eg2.EntityFramework;

namespace Wipro_API_EmployeeService_eg2.Repository
{
    public class EmployeeService:IEmployeeService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmployeeService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int CreateEmployee(Employee employee)
        {
            applicationDbContext.Add(employee);
            return applicationDbContext.SaveChanges();
        }

        public int DeleteEmployee(Employee employee)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            applicationDbContext.Employees.Remove(employee);
            return applicationDbContext.SaveChanges();
        }

        public Employee SearchEmployee(int id)
        {
            return applicationDbContext.Employees.SingleOrDefault(t => t.EmpID == id);
        }

        public int UpdateEmployee(Employee employee)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentException("Entity Missing");
            }
            applicationDbContext.Employees.Update(employee);
            return applicationDbContext.SaveChanges();
        }

       

        public IEnumerable<Employee> GetEmployees()
        {
            return applicationDbContext.Employees.ToList();
        }
    }
}
