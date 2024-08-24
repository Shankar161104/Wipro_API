using Wipro_API_EmployeeService_eg2.Model;

namespace Wipro_API_EmployeeService_eg2.Repository
{
    public interface IEmployeeService
    {

        IEnumerable<Employee> GetEmployees();
        Employee SearchEmployee(int id);

        int UpdateEmployee(Employee employee);
        int CreateEmployee(Employee employee);
        int DeleteEmployee(Employee employee);
    }
}
