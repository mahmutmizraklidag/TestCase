using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.Repositories;
using TestCase.Core.Services;
using TestCase.Repository.Repositories;

namespace TestCase.Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class, new()
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
             await _repository.AddAsync(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public T Find(int id)
        {
            return _repository.Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _repository.FindAsync(id);
        }

        public async Task<T> FirtOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.FirtOrDefaultAsync(expression);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
           return _repository.Get(expression);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expressions)
        {
            return _repository.GetAll(expressions);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return _repository.GetAllAsync(expression);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
