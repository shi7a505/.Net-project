using Microsoft.EntityFrameworkCore;
using RouteG04.DAL.Data.Context;
using RouteG04.DAL.Models.EmployeeModule;
using RouteG04.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.DAL.Repositories.Classes
{
    public class EmployeeRepository(ApplicationDBContext dBContext) : GenericRepository<Employee>(dBContext),IEmployeeRepository
    {
        private readonly ApplicationDBContext _dBContext = dBContext;

    }
}
