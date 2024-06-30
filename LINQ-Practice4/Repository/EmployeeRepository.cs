using LINQ_Practice4.Data;
using LINQ_Practice4.Models;

namespace LINQ_Practice4.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<tblEmployee> GetAllEmployees()
        {
            var employeeList = _context.tblEmployee.ToList();
            return employeeList;
        }
    }
}
