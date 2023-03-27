﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(int id);

      //  Task<TEntity> GetCompleteEntityAsync(int id);

        Task InsertAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);
    }
}
