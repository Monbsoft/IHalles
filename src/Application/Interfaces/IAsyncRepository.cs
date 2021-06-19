using Monbsoft.IHalles.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Application.Interfaces
{
    public interface IAsyncRepository<T> where T: BaseEntity, IAggregateRoot
    {
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken = default);
        ValueTask<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
