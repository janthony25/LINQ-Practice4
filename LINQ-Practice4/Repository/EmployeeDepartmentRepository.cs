using LINQ_Practice4.Data;
using LINQ_Practice4.Dto;
using Microsoft.EntityFrameworkCore;

namespace LINQ_Practice4.Repository
{
    public class EmployeeDepartmentRepository : IEmployeeDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeDepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EmployeeDepartmentDto> GetEmployeeDepartment()
        {
            return _context.tblEmployee
                .Include(e => e.tblDepartment)
                .Select(e => new EmployeeDepartmentDto
                {
                    EmployeeId = e.EmployeeId,
                    EmployeeName = e.EmployeeName,
                    EmployeeAge = e.EmployeeAge,
                    DepartmentName = e.tblDepartment.DepartmentName
                }).ToList();
        }
    }
}
