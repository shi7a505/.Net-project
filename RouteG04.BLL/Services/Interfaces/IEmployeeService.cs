using RouteG04.BLL.DTO.Department;
using RouteG04.BLL.DTO.Employee;
using RouteG04.DAL.Models.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDTO> GetAllEmployee(bool withTracking);
     
        EmployeeDetailsDto? GetEmployeeById(int id);

        int CreateEmployee(CreatedEmployeeDTO employeeDTO);

        int UpdateEmployee(UpdateEmployeeDTO employeeDTO );

        bool DeleteEmployee(int id);

    }
}
