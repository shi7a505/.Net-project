using RouteG04.BLL.DTO.Department;

namespace RouteG04.BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        int AddDepartment(CreatedDepartmentDTO departmentDTO);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentsDTO> GetAllDepartments();
        DepartmentDetailsDTO? GetDepartmentById(int id);
        int UpdeteDepartment(UpdatedDepartmentDTO departmentDTO);
    }
}