using Monbsoft.IHalles.Application.Interfaces;
using Monbsoft.IHalles.Application.Models;


namespace Monbsoft.IHalles.Infrastructure.Data.Repositories
{
    public class HalleRepository : DataRepository<Halle>, IHalleRepository
    {
        public HalleRepository(HallesDbContext context)
            : base(context)
        {
        }
    }
}
