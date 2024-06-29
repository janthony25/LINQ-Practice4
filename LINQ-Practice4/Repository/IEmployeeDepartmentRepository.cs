using LINQ_Practice4.Data;
using LINQ_Practice4.Dto;

namespace LINQ_Practice4.Repository
{
    public interface IEmployeeDepartmentRepository
    {

        List<EmployeeDepartmentDto> GetEmployeeDepartment();
    }
}
