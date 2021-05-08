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
        protected readonly IHallesDbContext _dataContext;

        public DataRepository(IHallesDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dataContext.Set<T>().ToListAsync(cancellationToken);
        }

        public async ValueTask<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var keyValues = new object[] { id };
            return await _dataContext.Set<T>().FindAsync(keyValues, cancellationToken);
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        


    }
}