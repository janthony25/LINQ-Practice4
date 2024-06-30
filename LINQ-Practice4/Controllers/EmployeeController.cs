using LINQ_Practice4.Data;
using LINQ_Practice4.Models;
using LINQ_Practice4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LINQ_Practice4.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ApplicationDbContext _context;
        public EmployeeController(IEmployeeRepository employeeRepository, ApplicationDbContext context)
        {
            _employeeRepository = employeeRepository;
            _context = context; 

        }

        public IActionResult Index()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return View(employees);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(tblEmployee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.tblEmployee.Add(employee);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeName", "EmployeeAge", "DepartmentId")] tblEmployee employee)
        {
            if(ModelState.IsValid)
            {
                _context.tblEmployee.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}
