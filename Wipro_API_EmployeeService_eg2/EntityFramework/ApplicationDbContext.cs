using Microsoft.EntityFrameworkCore;
using Wipro_API_EmployeeService_eg2.Model;


namespace Wipro_API_EmployeeService_eg2.EntityFramework
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
