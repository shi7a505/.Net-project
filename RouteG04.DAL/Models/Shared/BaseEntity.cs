using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.DAL.Models.Shared
{
    public class BaseEntity
    {
        public int Id { get; set; }//PK
        public int CreatedBy { get; set; }//UserId
        
        public DateTime? CreatedOn { get; set; }

        public int LastModificationBy { get; set; }//userId

        public DateTime? LastModeficationOn { get; set; }

        public bool IsDeleted { get; set; }//SoftDelete
    }
}
