using LINQ_Practice4.Data;
using LINQ_Practice4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LINQ_Practice4.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return View(employees);
        }
    }
}
