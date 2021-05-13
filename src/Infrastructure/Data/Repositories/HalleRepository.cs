using Monbsoft.IHalles.Application.Interfaces;
using Monbsoft.IHalles.Application.Models;
using System.Collections.Generic;
using System.Linq;


namespace Monbsoft.IHalles.Infrastructure.Data.Repositories
{
    public class HalleRepository : DataRepository<IHalle>, IHalleRepository
    {

        public HalleRepository(IHallesDbContext context)
            : base(context)
        {
        }

        public IEnumerable<IHalle> GetLastHalles(int count = 10)
        {
            return _dataContext.IHalles.OrderByDescending(h => h.Updated).Take(count);
        }
    }
}
