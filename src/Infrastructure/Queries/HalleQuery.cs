using Monbsoft.IHalles.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Infrastructure.Queries
{
    public class HalleQuery
    {
        private readonly HallesDbContext _dataContext;

        public HalleQuery(HallesDbContext dataContext)
        {
            _dataContext = dataContext;
        }



    }
}
