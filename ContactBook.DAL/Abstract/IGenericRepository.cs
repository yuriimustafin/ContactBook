using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.DAL.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity: class, IEntity
    {
        TEntity GetById(Guid id);
        TEntity Create(TEntity entity); 
    }
}
