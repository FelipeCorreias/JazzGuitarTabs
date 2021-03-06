﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JazzGuitarTabs.Application.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T t);
        void AddUnCommited(T t);
        Task<T> AddAsyn(T t);
        void AddUnCommitedAsync(T t);

        int Count();
        Task<int> CountAsync();
        void Delete(T entity);
        Task<int> DeleteAsyn(T entity);

        T FindFirst(Expression<Func<T, bool>> filter, params Expression<Func<T, bool>>[] includes);
        Task<T> FindFirstAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);

        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsyn();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(int id);

        T Update(T t, object key);
        Task<T> UpdateAsyn(T t, object key);

        List<T> GetWithFilterAndInclude(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);
    }
}
