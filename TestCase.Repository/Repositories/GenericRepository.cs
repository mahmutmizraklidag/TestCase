using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Repositories;

namespace TestCase.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet=_context.Set<T>();
        }

        public void Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task AddAsync(T entity)
        {
            try
            {
                _dbSet.AddAsync(entity);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var result = _dbSet.Find(id);
                if (result is not null)
                {
                    _dbSet.Remove(result);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> FirtOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).FirstOrDefaultAsync();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
           return _dbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
           return _dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expressions)
        {
            return _dbSet.Where(expressions).ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
