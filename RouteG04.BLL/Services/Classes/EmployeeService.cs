using RouteG04.BLL.DTO.Employee;
using RouteG04.BLL.Services.Interfaces;
using RouteG04.DAL.Models.EmployeeModule;
using RouteG04.DAL.Repositories.Interfaces;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.Services.Classes
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService

    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository;

        public IEnumerable<EmployeeDTO> GetAllEmployee(bool withTracking = false)
        {

            var Employees = _employeeRepository.GetAll(withTracking);
            var EmployeeDTO = Employees.Select(E => new EmployeeDTO()
            {
                Id = E.Id,
                Name = E.Name,
                Age = E.Age,
                Salary = E.Salary,
                IsActive = E.IsActive,
                Email = E.Email,
                EmployeeType = E.EmployeeType.ToString(),

            });
            return EmployeeDTO;
        }
        public EmployeeDetailsDto? GetEmployeeById(int id)
        {
            var Employee = _employeeRepository.GetById(id);
            return Employee is null ? null : new EmployeeDetailsDto()
            {
                //DateOnly.FromDateTime(Employee.HiringDate)
                Id = Employee.Id,
                Name = Employee.Name,
                Age = Employee.Age,
                Salary = Employee.Salary,
                IsActive = Employee.IsActive,
                Email = Employee.Email,
                EmpType = Employee.EmployeeType.ToString(),
                //HiringDate = Employee.HiringDate,
                HiringDate = Employee.HiringDate.HasValue
        ? DateOnly.FromDateTime(Employee.HiringDate.Value)
        : null,

                //HiringDate = DateOnly.FromDateTime(Employee.HiringDate),
                PhoneNumber = Employee.PhoneNumber,
                Address = Employee.Address,
                EmpGender = Employee.Gender.ToString(),
                CreatedBy = Employee.CreatedBy,
                CreatedOn = Employee.CreatedOn,
                LastModifiedOn =Employee.LastModeficationOn,
            };
        }
        public int UpdateEmployee(UpdateEmployeeDTO employeeDTO)
        {
            throw new NotImplementedException();
        }
        public int CreateEmployee(CreatedEmployeeDTO employeeDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
