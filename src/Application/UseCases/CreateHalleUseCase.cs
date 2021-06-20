using Monbsoft.IHalles.Application.Interfaces;
using Monbsoft.IHalles.Application.Models;
using Monbsoft.IHalles.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Application.UseCases
{
    public class CreateHalleUseCase
    {
        private readonly IHalleRepository _halleRepository;

        public CreateHalleUseCase(IHalleRepository halleRepository)
        {
            _halleRepository = Check.NotNull(halleRepository, nameof(halleRepository));
        }


        public async Task CreateAsync(IHalle halle)
        {

        }
    }
}
