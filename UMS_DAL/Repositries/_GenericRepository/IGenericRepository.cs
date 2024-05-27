using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_DAL.Repositries._GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetByID(int id);
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
