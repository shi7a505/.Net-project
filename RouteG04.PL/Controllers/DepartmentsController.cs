using Microsoft.AspNetCore.Mvc;
using RouteG04.BLL.DTO.Department;
using RouteG04.BLL.Services.Interfaces;
using RouteG04.PL.ViewModel.DepartmentViewModel;

namespace RouteG04.PL.Controllers
{
    public class DepartmentsController(IDepartmentService departmentService ,ILogger<DepartmentsController> logger, IWebHostEnvironment environment) : Controller
    {
        private readonly IDepartmentService _departmentService = departmentService;
        private readonly ILogger<DepartmentsController> _logger = logger;
        private readonly IWebHostEnvironment _environment = environment;

        public IActionResult Index()
        {
            var Departments = _departmentService.GetAllDepartments();
            return View(Departments);
        }

        #region Create
        [HttpGet]
     
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatedDepartmentDTO departmentDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int Result = _departmentService.AddDepartment(departmentDTO);
                    if (Result > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(String.Empty, "Department Can not Be Created");
                        //return View(departmentDTO);
                    }

                }
                catch (Exception ex)
                {
                    //log Exception
                    //Devlopement
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);
                        //return View(departmentDTO);
                    }
                    //Deployment
                    else
                    {
                        _logger.LogError(ex.Message);
                        //return View (departmentDTO);
                    }

                }
            }
            //else
            //{
            //    return View(departmentDTO);
            //}
            return View(departmentDTO);

        }

        #endregion
        #region Detail
        [HttpGet]
        public IActionResult Details(int ?id)
        {
            if (!id.HasValue) return BadRequest();
            var Department = _departmentService.GetDepartmentById(id.Value);
            if (Department is null) return NotFound();
            return View(Department);
        }
        #endregion
        #region Edit
        [HttpGet]
        public IActionResult Edit(int ? id)
        {
            if (!id.HasValue) return BadRequest();
            var Department = _departmentService.GetDepartmentById(id.Value);
            if (Department is null) return NotFound();
            var DepartmentViewModel = new DepartmentEditViewModel()
            {
                Code = Department.Code,
                Name = Department.Name,
                description = Department.description,
                DateOfCreation = Department.DateOfCreation

            };
            return View(DepartmentViewModel);

        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int ? id , DepartmentEditViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            try
            {
                var UpdateDepartment = new UpdatedDepartmentDTO
                {
                    DeptId = id.Value,
                    Code = viewModel.Code,
                    Name = viewModel.Name,
                    description = viewModel.description,
                    DateOfCreation = viewModel.DateOfCreation


                };
                int Result = _departmentService.UpdeteDepartment(UpdateDepartment);
                if (Result > 0) {
                    
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Department Can not Be Updated");
                }

            }
            catch (Exception ex)
            {
                //log Exception
                //Devlopement
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                //Deployment
                else
                {
                    _logger.LogError(ex.Message);
                }
           }
            return View(viewModel);

        }
        #endregion
        #region Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var Department = _departmentService.GetDepartmentById(id.Value);
            if (Department is null) return NotFound();
            return View(Department);
        }
        [HttpPost]
        public IActionResult Delete([FromRoute]int id)
        {
            if (id == 0) return BadRequest();
            try
            {
                bool Deleted = _departmentService.DeleteDepartment(id);
                if (Deleted)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Department Is Not Deleted");
                    return RedirectToAction(nameof(Delete), new { id });
                }
            }
            catch (Exception ex)
            {
                //log Exception
                //Devlopement
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                //Deployment
                else
                {
                    _logger.LogError(ex.Message);
                }

            }
            return RedirectToAction(nameof(Index));

        }


        #endregion
    }
}
