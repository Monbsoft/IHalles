using Monbsoft.IHalles.SharedKernel;
using System.Threading;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Application.Interfaces
{
    public interface IAsyncRepository<T> where T: BaseEntity, IAggregateRoot
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
    }
}
