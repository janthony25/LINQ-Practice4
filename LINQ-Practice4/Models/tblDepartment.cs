using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice4.Models
{
    public class tblDepartment
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<tblEmployee> tblEmployee { get; set; }
    }
}
