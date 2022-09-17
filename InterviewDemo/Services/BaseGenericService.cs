﻿using InterviewDemo.Abstractions;
using InterviewDemo.Model;
using InterviewDemo.Repository;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.Services
{
    public abstract class BaseGenericService<T> : IBaseGenericService<T> where T : class
    {
        IBaseGenericRepository<T> _repository;
       
        public BaseGenericService(IBaseGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<int> Add(T entity)
        {

            return await _repository.Add(entity);
        }

        public virtual async Task<int> Delete(T entity)
        {
           return await _repository.Delete(entity);
        }

        public virtual async Task<T?> Get(int id) => await _repository.Get(id);

        public virtual async Task<ICollection<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<int> Update(T entity)
        {
            return await _repository.Update(entity);
        }
    }
}
