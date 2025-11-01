using Microsoft.EntityFrameworkCore;
using RouteG04.DAL.Data.Context;
using RouteG04.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity>(ApplicationDBContext dBContext) : IGenericRepository<TEntity> where TEntity : BaseEntity

    {
        private readonly ApplicationDBContext _dBContext = dBContext;

        public IEnumerable<TEntity> GetAll(bool withTracking = false)
        {
            if (withTracking) //true
            {
                return _dBContext.Set<TEntity>().ToList();
            }
            else
            {
                return _dBContext.Set<TEntity>().AsNoTracking().ToList();
            }

        }


        //Get Department By Id
        public TEntity? GetById(int id /* , ApplicationDBContext dbContext*/ )
        {
            var entity = _dBContext.Set<TEntity>().Find(id);
            return entity;
        }

        //Add
        public int Add(TEntity entity)
        {
            _dBContext.Set<TEntity>().Add(entity);//local
            return _dBContext.SaveChanges();

        }
        //update
        public int Udate(TEntity entity)
        {
            _dBContext.Set<TEntity>().Update(entity); //local
            return _dBContext.SaveChanges();
        }

        //delete
        public int Remove(TEntity entity)
        {
            _dBContext.Set<TEntity>().Remove(entity); //local
            return _dBContext.SaveChanges();

        }
    }
}
