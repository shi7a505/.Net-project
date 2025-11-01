using RouteG04.BLL.DTO.Department;
using RouteG04.DAL.Models.DepartmentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.Factories
{
    public static class DepartmentFactory
    {
        //Get All
        public static DepartmentsDTO ToDepartmentDto (this Department D)
        {
            return new DepartmentsDTO()
            {
                DeptId = D.Id,

                Name = D.Name,
                Code = D.Code,
                DateOfCreation = D.CreatedOn,
                description = D.description
            };
        }
        //Get by Id
        public static DepartmentDetailsDTO ToDepartmentDetailsDto ( this Department D)

        {
            return new DepartmentDetailsDTO()
            {
                DeptId = D.Id,
                Name = D.Name,
                Code = D.Code,
                description = D.description,
                DateOfCreation = D.CreatedOn,
                CreatedBy = D.CreatedBy,
                LastModificationBy = D.LastModificationBy,
                LastModeficationOn = D.LastModeficationOn,
                IsDeleted = D.IsDeleted
            };
        }
        //Add
        public static Department ToEntity (this CreatedDepartmentDTO departmentDTO)
        {
            return new Department()
            {
                Name = departmentDTO.Name,
                Code = departmentDTO.Code,
                description = departmentDTO.description,
            };
        }
        //update
        public static Department ToEntity (this UpdatedDepartmentDTO departmentDTO)
        {
            return new Department()
            {
                Id = departmentDTO.DeptId,
                Name = departmentDTO.Name,
                Code = departmentDTO.Code,
                description = departmentDTO.description,
                CreatedOn = departmentDTO.DateOfCreation,
            };
        }
    }
}
