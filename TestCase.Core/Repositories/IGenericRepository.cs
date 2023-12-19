using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Core.Repositories
{
    public interface IGenericRepository <T> where T : class, new()
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expressions);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        //Asenkron metotlar
        Task<T> FindAsync(int id);
        Task<T> FirtOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
    }
}
