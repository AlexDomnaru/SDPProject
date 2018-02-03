using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain.Entities;

namespace Business.Interfaces
{
    public interface IRepository<T> where T: IEntity
    {
	    Task<IEnumerable<T>> GetAll();
	    Task<T> GetById(Guid id);
	    Task<bool> Create(T entity);
	    Task<bool> Update(T entity);
	    Task<bool> Delete(T entity);
	    Task<bool> Exists(Guid id);
    }
}
