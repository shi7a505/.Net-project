using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.BLL.DTO.Department
{
    public  class CreatedDepartmentDTO
    {
        [Required (ErrorMessage = "Name is Required !!")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Code is Required !!")]

        public string Code { get; set; } = null!;

        public string? description { get; set; }


        public DateTime? DateOfCreation { get; set; }
    }
}
