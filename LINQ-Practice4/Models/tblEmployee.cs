using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ_Practice4.Models
{
    public class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public int DepartmentId { get; set; }
        public tblDepartment? tblDepartment { get; set; }
    }
}
