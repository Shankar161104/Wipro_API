using Microsoft.EntityFrameworkCore;
using Wipro_API_Customer_Service_Model.Model;


namespace Wipro_API_Customer_Service_Model.EntityFramework
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
