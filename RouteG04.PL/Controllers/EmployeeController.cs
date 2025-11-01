using Microsoft.AspNetCore.Mvc;
using RouteG04.BLL.DTO.Employee;
using RouteG04.BLL.Services.Interfaces;
using RouteG04.DAL.Models.EmployeeModule;

namespace RouteG04.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployee(true);
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatedEmployeeDTO? employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            _employeeService.CreateEmployee(employee!);
            return RedirectToAction("Index");
        }
    }
}