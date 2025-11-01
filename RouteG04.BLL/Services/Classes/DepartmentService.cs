using RouteG04.BLL.DTO.Department;
using RouteG04.BLL.Factories;
using RouteG04.BLL.Services.Interfaces;
using RouteG04.DAL.Models;
using RouteG04.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.Services.Classes
{
    public class DepartmentService(IDepartmentRepository departmentRepository) :IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository = departmentRepository;

        //Get all departments
        public IEnumerable<DepartmentsDTO> GetAllDepartments()
        {
            var Departments = _departmentRepository.GetAll();
            return Departments.Select(D => D.ToDepartmentDto());
        }

        //Get Department By Id
        public DepartmentDetailsDTO? GetDepartmentById(int id)
        {
            var Department = _departmentRepository.GetById(id);


            return Department is null ? null : Department.ToDepartmentDetailsDto();
        }

        //Add

        public int AddDepartment(CreatedDepartmentDTO departmentDTO)
        {
            var Department = departmentDTO.ToEntity();
            return _departmentRepository.Add(Department);
        }

        //update
        public int UpdeteDepartment(UpdatedDepartmentDTO departmentDTO)
        {
            return _departmentRepository.Udate(departmentDTO.ToEntity());
            return _departmentRepository.Udate(departmentDTO.ToEntity());

        }

        //delete
        public bool DeleteDepartment(int id)
        {
            var Department = _departmentRepository.GetById(id);
            if (Department is null) return false;
            else
            {
                var Result = _departmentRepository.Remove(Department);
                return Result > 0 ? true : false;
            }
        }
    }

}
