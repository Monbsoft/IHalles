using Monbsoft.IHalles.Application.Models;
using System.Collections.Generic;

namespace Monbsoft.IHalles.Application.Interfaces
{
    public interface IHalleRepository
    {
        IEnumerable<IHalle> GetLastHalles(int count = 10);
    }
}