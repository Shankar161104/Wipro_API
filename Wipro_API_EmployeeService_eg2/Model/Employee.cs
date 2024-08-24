
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;


namespace Wipro_API_EmployeeService_eg2.Model
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public int EmpAge { get; set; }
        public string EmpContact { get; set; }
        public string EmpCity { get; set; }
        public string EmpQualification { get; set; }
    }
}
