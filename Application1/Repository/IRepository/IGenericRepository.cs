﻿using System.Linq.Expressions;

namespace Application1.Repository.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracking = true);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
