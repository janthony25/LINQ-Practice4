using LINQ_Practice4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LINQ_Practice4.Controllers
{
    public class EmployeeDepartmentController : Controller
    {
        private readonly IEmployeeDepartmentRepository _employeeDepartmentRepository;
        public EmployeeDepartmentController(IEmployeeDepartmentRepository employeeDepartmentRepository)
        {
            _employeeDepartmentRepository = employeeDepartmentRepository;
        }
        public IActionResult Index()
        {
            var employeeDepartment = _employeeDepartmentRepository.GetEmployeeDepartment();
            return View(employeeDepartment);
        }
    }
}
