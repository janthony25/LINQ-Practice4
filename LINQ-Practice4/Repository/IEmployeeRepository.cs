using LINQ_Practice4.Models;

namespace LINQ_Practice4.Repository
{
    public interface IEmployeeRepository
    {
        List<tblEmployee> GetAllEmployees();
    }
}
