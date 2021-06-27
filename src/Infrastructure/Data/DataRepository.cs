using Microsoft.EntityFrameworkCore;
using Monbsoft.IHalles.Application.Interfaces;
using Monbsoft.IHalles.SharedKernel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Infrastructure.Data
{
    public class DataRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly HallesDbContext _dataContext;

        public DataRepository(HallesDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dataContext.Set<T>().Add(entity);
            await _dataContext.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}