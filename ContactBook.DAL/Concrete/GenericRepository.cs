using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactBook.DAL.Abstract;

namespace ContactBook.DAL.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity: class, IEntity
    {
        private ApplicationContext _context;
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        public TEntity Create(TEntity entity)
        {
            var result = _context.Set<TEntity>()
                .Add(entity).Entity;

            // TODO: Consider to remove it to separate method and call it from Domain layer
            _context.SaveChanges();
            return result;
        }

        // TODO: Consider to remove this logic to Domain layer and stay here only GetByCondition(...)
        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>()
                .Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
