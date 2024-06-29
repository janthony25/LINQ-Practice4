using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice4.Models
{
    public class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
    }
}
