using RouteG04.DAL.Data.Context;
using RouteG04.DAL.Models.DepartmentModule;
using RouteG04.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.DAL.Repositories.Classes
{
    public class DepartmentRepository(ApplicationDBContext dBContext) :GenericRepository<Department>(dBContext),IDepartmentRepository
    {
        private readonly ApplicationDBContext _dBContext = dBContext;
       
       
    }
}
