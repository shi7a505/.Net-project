using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.DTO.Department
{
    public class DepartmentDetailsDTO
    {
        public int DeptId { get; set; }//PK
        public string Name { get; set; } = null!;

        public string Code { get; set; } = null!;

        public string? description { get; set; }

        public DateTime? DateOfCreation { get; set; }
        public int CreatedBy { get; set; }//UserId
        public int LastModificationBy { get; set; }//userId

        public DateTime? LastModeficationOn { get; set; }

        public bool IsDeleted { get; set; }//SoftDelete

    }
}
